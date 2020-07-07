using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
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
        public IActionResult GetUsers()
        {

                var m_users = _repository.User.GetAllUsers(trackChanges: false);
                //return Ok(organizations);
                var UserDto = _mapper.Map<IEnumerable<UserDto>>(m_users);
                //throw new Exception("Exception");
                return Ok(UserDto);


        }
        [HttpGet("{id}")]
        public IActionResult GetOrganizationy(Guid id)
        {
            try
            {
                var organization = _repository.User.GetUser(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var organizationDto = _mapper.Map<UserDto>(organization);
                    return Ok(organizationDto);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetUsers)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPost(Name = "createUser")]
        public IActionResult CreateOrganization([FromBody] UserForCreationDto user)
        {
            if (user == null)
            {
                _logger.LogError("User ForCreationDto object sent from client is null.");
                return BadRequest("User ForCreationDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForCreationDto object");
                return UnprocessableEntity(ModelState);
            }

            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<UserDto>(userEntity);

            return CreatedAtRoute("getOrganizationById", new { id = userToReturn.id }, userToReturn);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrganization(Guid id, [FromBody] UserForUpdateDto user)
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
        public IActionResult DeleteOrganization(Guid id)
        {
            var organization = _repository.User.GetUser(id, trackChanges: false);
            if (organization == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.User.DeleteUser(organization);
            _repository.Save();

            return NoContent();
        }
    }
}