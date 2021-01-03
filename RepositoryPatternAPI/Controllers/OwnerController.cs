using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.Models;
using Entities.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RepositoryPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper repository;
        private readonly IMapper mapper;

        public OwnerController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOwners()
        {
            try
            {
                var owners = await repository.Owner.GetAllOwnersAsync();
                _logger.LogInfo($"Returned all owners from database.");

                var ownersResult = mapper.Map<IEnumerable<OwnerViewModel>>(owners);

                return Ok(ownersResult);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");
                return StatusCode(500, "Internal Server Error!");
            }
        }

        [HttpGet("{id}",Name = "getOwnerById")]
        public async Task<IActionResult> GetOwnerById(Guid id)
        {
            try
            {
                var owner = await repository.Owner.GetOwnerByIdAsync(id);

                if (owner == null)
                {
                    _logger.LogError($"Owner with Id: {id}, hasn't been found in db");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with id: {id}");

                    var ownerResult = mapper.Map<OwnerViewModel>(owner);

                    return Ok(ownerResult);
                }
                
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
                return StatusCode(500, "Internal Server Error!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOwner([FromBody]OwnerForCreationViewModel owner)
        {
            try
            {
                if (owner == null)
                {
                    _logger.LogError($"Owner object sent from client is null");
                    return BadRequest("Owner object is null");
                }

                if(!ModelState.IsValid)
                {
                    _logger.LogError($"Invalid Owner object sent from client");
                    return BadRequest("Invalid Owner object");
                }

                var ownerEntity = mapper.Map<Owner>(owner);

                repository.Owner.CreateOwner(ownerEntity);
                await repository.SaveAsync();

                var createdOwner = mapper.Map<OwnerViewModel>(ownerEntity);

                return CreatedAtRoute("getOwnerById", new { id = createdOwner.OwnerId }, createdOwner);

            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateOwner action: {ex.Message}");
                return StatusCode(500, "Internal Server Error!");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOwner(Guid id, [FromBody]OwnerForUpdateViewModel owner)
        {
            try
            {
                if (owner == null)
                {
                    _logger.LogError("Owner object sent from client is null.");
                    return BadRequest("Owner object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("$");
                    return BadRequest("Invalid model object");
                }

                var ownerEntity = await repository.Owner.GetOwnerByIdAsync(id);

                if (ownerEntity == null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't found in DB");
                    return NotFound();
                }

                //mapper.Map(owner, ownerEntity);
                mapper.Map(owner, ownerEntity);

                repository.Owner.updateOwner(ownerEntity);
                await repository.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateOwner action: {ex.Message}");
                return StatusCode(500, "Internal Server Error!");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(Guid id)
        {
            try
            {
                var owner = await repository.Owner.GetOwnerByIdAsync(id);

                if (owner == null)
                {
                    _logger.LogError($"Owner with Id: {id} hasn't found in DB");
                    return NotFound();
                }

                repository.Owner.DeleteOwner(owner);
                await repository.SaveAsync();

                return NoContent();

            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteOwner action: {ex.Message}");
                return StatusCode(500, "Internal Server Error!");
            }
        }

    }
}