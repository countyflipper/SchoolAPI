using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/CourseManages")]
    [ApiController]
    public class CourseManagementController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CourseManagementController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCourseManages()
        {
            //try
            //{
                var organizations = _repository.CourseManagement.GetAllCourseManagment(trackChanges: false);

                var UserDto = _mapper.Map<IEnumerable<CourseManageDTO>>(organizations);
                return Ok(organizations);
                /*var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);
                return Ok(organizationDto);*/

            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Something went wrong in the {nameof(GetCourseManages)} action {ex}");
            //    return StatusCode(500, "Internal server error");
            //}
        }



        [HttpGet("{id}")]
        public IActionResult GetOrganizationy(Guid id)
        {
            try
            {
                var organization = _repository.CourseManagement.GetCourseManagement(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"Organization with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var organizationDto = _mapper.Map<CourseManageDTO>(organization);
                    return Ok(organizationDto);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCourseManages)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }

        /**************************************************************************************/

        [HttpPost(Name = "CourseManageByID")]
        public IActionResult CreateOrganization([FromBody] CourseManageForCreationDto CourseManage)
        {
            if (CourseManage == null)
            {
                _logger.LogError("CourseManage ForCreationDto object sent from client is null.");
                return BadRequest("CourseManage ForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseManageForCreationDto object");
                return UnprocessableEntity(ModelState);
            }
            var coursemanageEntity = _mapper.Map<CourseManagement>(CourseManage);

            _repository.CourseManagement.CreateCourseManagement(coursemanageEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<CourseManageDTO>(coursemanageEntity);

            return CreatedAtRoute("CourseManageByID", new { id = userToReturn.AssigmentID }, userToReturn);
        }

        /**************************************************************************************/
        [HttpPut("{id}")]
        public IActionResult UpdateCourseManagment(Guid id, [FromBody] CourseManageForUpdateDto coursemanage)
        {
            if (coursemanage == null)
            {
                _logger.LogError("CourseManageForUpdateDto object sent from client is null.");
                return BadRequest("CourseManageForUpdateDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var coursemanageEntity = _repository.CourseManagement.GetCourseManagement(id, trackChanges: true);
            if (coursemanageEntity == null)
            {
                _logger.LogInfo($"CourseManage with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(coursemanage, coursemanageEntity);
            _repository.Save();

            return NoContent();
        }

        /**************************************************************************************/
        [HttpDelete("{id}")]
        public IActionResult DeleteCourseManagment(Guid id)
        {
            var organization = _repository.CourseManagement.GetCourseManagement(id, trackChanges: false);
            if (organization == null)
            {
                _logger.LogInfo($"CourseManage with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.CourseManagement.DeleteCourseManagement(organization);
            _repository.Save();

            return NoContent();
        }

        /**************************************************************************************/
    }
}