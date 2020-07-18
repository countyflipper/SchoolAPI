using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.RequestFeatures;
using SchoolAPI.ActionFilters;
using Microsoft.AspNetCore.JsonPatch;


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

        public UserController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersAll( [FromQuery] UserParameter employeeParameters)
        {
            if (!employeeParameters.ValidAgeRange)
                return BadRequest("Max age can't be less than min age.");


            var employeesFromDb = await _repository.User.GetAllUserAsync( employeeParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(employeesFromDb.MetaData));

            var employeesDto = _mapper.Map<IEnumerable<UserDto>>(employeesFromDb);

            return Ok(employeesDto);
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

            var employee = _mapper.Map<UserDto>(userDb);

            return Ok(employee);
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


    }
}