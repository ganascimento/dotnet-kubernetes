using Microsoft.AspNetCore.Mvc;
using SalesAd.Application.UseCases.Owner.ActiveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.CreateOwnerUseCase;
using SalesAd.Application.UseCases.Owner.RemoveOwnerUseCase;
using SalesAd.Application.UseCases.Owner.UpdateOwnerUseCase;

namespace SalesAd.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly IActiveOwnerUseCase _activeOwnerUseCase;
        private readonly ICreateOwnerUseCase _createOwnerUseCase;
        private readonly IUpdateOwnerUseCase _updateOwnerUseCase;
        private readonly IRemoveOwnerUseCase _removeOwnerUseCase;

        public OwnerController(
            IActiveOwnerUseCase activeOwnerUseCase,
            ICreateOwnerUseCase createOwnerUseCase,
            IUpdateOwnerUseCase updateOwnerUseCase,
            IRemoveOwnerUseCase removeOwnerUseCase)
        {
            _activeOwnerUseCase = activeOwnerUseCase;
            _createOwnerUseCase = createOwnerUseCase;
            _updateOwnerUseCase = updateOwnerUseCase;
            _removeOwnerUseCase = removeOwnerUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateOwnerModel model)
        {
            try
            {
                await _createOwnerUseCase.Execute(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateOwnerModel model)
        {
            try
            {
                await _updateOwnerUseCase.Execute(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{ownerId}")]
        public async Task<IActionResult> RemoveAsync(Guid ownerId)
        {
            try
            {
                await _removeOwnerUseCase.Execute(ownerId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("active/{ownerId}")]
        public async Task<IActionResult> ActiveAsync(Guid ownerId)
        {
            try
            {
                await _activeOwnerUseCase.Execute(ownerId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}