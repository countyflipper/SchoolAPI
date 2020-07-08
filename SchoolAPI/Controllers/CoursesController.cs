using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CoursesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            try
            {
                var organizations = _repository.Course.GetAllCourses(trackChanges: false);
                return Ok(organizations);
                /*var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);
                return Ok(organizationDto);*/

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCourses)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetOrganizationy(Guid id)
        {
            try
            {
                var organization = _repository.User.GetUser(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"Organization with id: {id} doesn't exist in the database.");
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
                _logger.LogError($"Something went wrong in the {nameof(GetCourses)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }
    }
}