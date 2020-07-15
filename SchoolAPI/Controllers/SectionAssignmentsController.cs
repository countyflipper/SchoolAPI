using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SchoolAPI.Controllers
{
    [Route("api/v1/SectionAssign")]
    [ApiController]
    public class SectionAssignmentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SectionAssignmentsController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSectionAssign()
        {
            try
            {
                var organizations = _repository.SectionAssign.GetAllSectionAssigns(trackChanges: false);
                return Ok(organizations);
                /*var organizationDto = _mapper.Map<IEnumerable<OrganizationDto>>(organizations);
                return Ok(organizationDto);*/

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetSectionAssign)} action {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetSectionAssigny(Guid id)
        {
            try
            {
                var organization = _repository.SectionAssign.GetSectionAssign(id, trackChanges: false); if (organization == null)
                {
                    _logger.LogInfo($"SectionAssign with id: {id} doesn't exist in the database.");
                    return NotFound();
                }
                else
                {
                    var SectionAssignDTO = _mapper.Map<SectionAssignDTO>(organization);
                    return Ok(SectionAssignDTO);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetSectionAssign)} action {ex}");
                return StatusCode(500, "Internal server error");
            }

        }





        [HttpPost(Name = "SectionAssignByID")]
        public IActionResult CreateSectionAssign([FromBody] SectionAssignForCreationDTO sectionassign)
        {
            if (sectionassign == null)
            {
                _logger.LogError("course CourseForCreationDto object sent from client is null.");
                return BadRequest("course CourseForCreationDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CourseForCreationDto object");
                return UnprocessableEntity(ModelState);
            }

            var SectionAssignEntity = _mapper.Map<SectionAssign>(sectionassign);

            _repository.SectionAssign.CreateSectionAssign(SectionAssignEntity);
            _repository.Save();

            var userToReturn = _mapper.Map<SectionAssignDTO>(SectionAssignEntity);

            return CreatedAtRoute("SectionAssignByID", new { id = userToReturn.AssignID }, userToReturn);
        }






        [HttpPut("{id}")]
        public IActionResult UpdateSectionAssign(Guid id, [FromBody] SectionAssignForUpdateDTO sectionassign)
        {
            if (sectionassign == null)
            {
                _logger.LogError("SectionAssignForUpdateDTO object sent from client is null.");
                return BadRequest("SectionAssignForUpdateDTO object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the SectionAssignForUpdateDTO object");
                return UnprocessableEntity(ModelState);
            }
            var sectionassignEntity = _repository.SectionAssign.GetSectionAssign(id, trackChanges: true);
            if (sectionassignEntity == null)
            {
                _logger.LogInfo($"SectionAssign with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(sectionassign, sectionassignEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSectionAssign(Guid id)
        {
            var SectionAssign = _repository.SectionAssign.GetSectionAssign(id, trackChanges: false);
            if (SectionAssign == null)
            {
                _logger.LogInfo($"SectionAssign with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.SectionAssign.DeleteSectionAssign(SectionAssign);
            _repository.Save();

            return NoContent();
        }
    }
}