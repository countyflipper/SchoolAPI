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
        public async Task<IActionResult> GetCourses(Guid courseID, [FromQuery] CoursesParameters coursesParameters)
        {
            var company = await _repository.Course.GetCoursesAsync(courseID, coursesParameters, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Course with id: {courseID} doesn't exist in the database.");
                return NotFound();
            }

            var coursesFromDb = await _repository.Course.GetCoursesAsync(courseID, coursesParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(coursesFromDb.MetaData));

            var coursesDTO = _mapper.Map<IEnumerable<CourseDto>>(coursesFromDb);

            return Ok(coursesDTO);
        }




        [HttpGet("{id}")]
        public IActionResult GetCousesy(Guid id)
        {
            try
            {
                var organization = _repository.Course.GetCourse(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"Course with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var CourseDto = _mapper.Map<Courses>(organization);
                    return Ok(CourseDto);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCourses)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }






        [HttpPost(Name = "CourseByID")]
        public IActionResult CreateCourse([FromBody] CourseForCreationDto course)
        {
            if (course == null)
            {
                _logger.LogError("course CourseForCreationDto object sent from client is null.");
                return BadRequest("course CourseForCreationDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseForCreationDto object");
                return UnprocessableEntity(ModelState);
            }

            var courseEntity = _mapper.Map<Courses>(course);

            _repository.Course.CreateCourse(courseEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<CourseDto>(courseEntity);

            return CreatedAtRoute("CourseByID", new { id = userToReturn.id }, userToReturn);
        }






        [HttpPut("{id}")]
        public IActionResult UpdateOrganization(Guid id, [FromBody] CourseForUpdateDto course)
        {
            if (course == null)
            {
                _logger.LogError("CourseForUpdateDto object sent from client is null.");
                return BadRequest("CourseForUpdateDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var courseEntity = _repository.Course.GetCourse(id, trackChanges: true);
            if (courseEntity == null)
            {
                _logger.LogInfo($"course with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(course, courseEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrganization(Guid id)
        {
            var organization = _repository.Course.GetCourse(id, trackChanges: false);
            if (organization == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.Course.DeleteCourse(organization);
            _repository.Save();

            return NoContent();
        }
    }
}