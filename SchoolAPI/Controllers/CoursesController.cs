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
        public async Task<IActionResult> GetEmployeesForCompany( [FromQuery] CoursesParameters employeeParameters)
        {
            //var company = await _repository.Course.GetCourseAsync(companyId, trackChanges: false);
            //if (company == null)
            //{
            //    _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
            //    return NotFound();
            //}

            var employeesFromDb = await _repository.Course.GetCoursesAsync( employeeParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(employeesFromDb.MetaData));

            var employeesDto = _mapper.Map<IEnumerable<CourseDto>>(employeesFromDb);

            return Ok(employeesDto);
        }

        [HttpGet("{id}", Name = "GetEmployeeForCompany")]
        public async Task<IActionResult> GetEmployeeForCompany(Guid id)
        {
            var company = await _repository.Course.GetCourseAsync(id, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database.");
                return NotFound();
            }


            var employee = _mapper.Map<CourseDto>(company);

            return Ok(employee);
        }


        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateEmployeeForCompany(Guid companyId, [FromBody] CourseForCreationDto employee)
        {
            var company = await _repository.Course.GetCourseAsync(companyId, trackChanges: false);
            if (company == null)
            {
                _logger.LogInfo($"Company with id: {companyId} doesn't exist in the database.");
                return NotFound();
            }

            var employeeEntity = _mapper.Map<Courses>(employee);

            _repository.Course.CreateCourse(employeeEntity);
            await _repository.SaveAsync();

            var employeeToReturn = _mapper.Map<CourseDto>(employeeEntity);

            return CreatedAtRoute("GetEmployeeForCompany", new { companyId, id = employeeToReturn.id }, employeeToReturn);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateCourseExistsAttribute))]
        public async Task<IActionResult> DeleteEmployeeForCompany(Guid companyId, Guid id)
        {
            var employeeForCompany = HttpContext.Items["employee"] as Courses;

            _repository.Course.DeleteCourse(employeeForCompany);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateCourseExistsAttribute))]
        public async Task<IActionResult> UpdateEmployeeForCompany(Guid companyId, Guid id, [FromBody] CourseForUpdateDto employee)
        {
            var employeeEntity = HttpContext.Items["employee"] as Courses;

            _mapper.Map(employee, employeeEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ServiceFilter(typeof(ValidateCourseExistsAttribute))]
        public async Task<IActionResult> PartiallyUpdateEmployeeForCompany(Guid companyId, Guid id, [FromBody] JsonPatchDocument<CourseForUpdateDto> patchDoc)
        {
            if (patchDoc == null)
            {
                _logger.LogError("patchDoc object sent from client is null.");
                return BadRequest("patchDoc object is null");
            }

            var employeeEntity = HttpContext.Items["employee"] as Courses;

            var employeeToPatch = _mapper.Map<CourseForUpdateDto>(employeeEntity);

            patchDoc.ApplyTo(employeeToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            TryValidateModel(employeeToPatch);

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the patch document");
                return UnprocessableEntity(ModelState);
            }

            _mapper.Map(employeeToPatch, employeeEntity);

            await _repository.SaveAsync();

            return NoContent();
        }
    }
}