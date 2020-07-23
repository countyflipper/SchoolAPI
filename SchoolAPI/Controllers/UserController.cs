using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SchoolAPI.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly IDataShaper<UserDto> _dataShaper;


        public UserController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper, IDataShaper<UserDto> dataShaper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
            _dataShaper = dataShaper;
        }

        [HttpGet]
        [HttpHead]
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        public async Task<IActionResult> GetUsersAll( [FromQuery] UserParameter userParameters)
        {
            if (!userParameters.ValidAgeRange)
                return BadRequest("Max age can't be less than min age.");


            var usersFromDb = await _repository.User.GetAllUserAsync( userParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(usersFromDb.MetaData));

            var userDto = _mapper.Map<IEnumerable<UserDto>>(usersFromDb);

            return Ok(_dataShaper.ShapeData(userDto, userParameters.Fields));
        }



        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(Guid id)
        {


            var userDb = await _repository.User.GetUser( id, trackChanges: false);
            if (userDb == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            var user = _mapper.Map<UserDto>(userDb);

            return Ok(user);
        }

        [HttpPost(Name = "UserByID")]
        public IActionResult CreateUser([FromBody] UserForCreationDto user)
        {
            if (user == null)
            {
                _logger.LogError("User ForCreationDto object sent from client is null.");
                return BadRequest("User ForCreationDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }

            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<UserDto>(userEntity);

            return CreatedAtRoute("UserByID", new { id = userToReturn.id }, userToReturn);
        }





        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDto user)
        {
            if (user == null)
            {
                _logger.LogError("UserForUpdateDto object sent from client is null.");
                return BadRequest("UserForUpdateDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var userEntity = _repository.User.GetUser(id, trackChanges: true);
            if (userEntity == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(user, userEntity);
            _repository.Save();

            return NoContent();
        }




        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser( Guid id)
        {
            var user = await _repository.User.GetUser(id, trackChanges: false); 
            if (user == null) 
            { 
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database."); 
                return NotFound(); 
            }
            _repository.User.DeleteUser(user); 

            await _repository.SaveAsync(); 

            return NoContent();
        }


        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateUserExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateUsers(Guid id, [FromBody] JsonPatchDocument<UserForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var userEntity = HttpContext.Items["employee"] as User;

            var userToPatch = _mapper.Map<UserForUpdateDto>(userEntity);

            patchDoc.ApplyTo(userToPatch, ModelState);

            TryValidateModel(userToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(userToPatch, userEntity);

            await _repository.SaveAsync();

            return NoContent();
        }


    }
}