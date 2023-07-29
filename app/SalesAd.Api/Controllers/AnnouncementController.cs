using Microsoft.AspNetCore.Mvc;
using SalesAd.Application.UseCases.Announcement.CreateAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetAllAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByIdAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.GetByOwnerAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.RemoveAnnouncementUseCase;
using SalesAd.Application.UseCases.Announcement.UpdateAnnouncementUseCase;

namespace SalesAd.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IGetAllAnnouncementUseCase _getAllAnnouncementUseCase;
        private readonly IGetByIdAnnouncementUseCase _getByIdAnnouncementUseCase;
        private readonly IGetByOwnerAnnouncementUseCase _getByOwnerAnnouncementUseCase;
        private readonly ICreateAnnouncementUseCase _createAnnouncementUseCase;
        private readonly IUpdateAnnouncementUseCase _updateAnnouncementUseCase;
        private readonly IRemoveAnnouncementUseCase _removeAnnouncementUseCase;

        public AnnouncementController(
            IGetAllAnnouncementUseCase getAllAnnouncementUseCase,
            IGetByIdAnnouncementUseCase getByIdAnnouncementUseCase,
            IGetByOwnerAnnouncementUseCase getByOwnerAnnouncementUseCase,
            ICreateAnnouncementUseCase createAnnouncementUseCase,
            IUpdateAnnouncementUseCase updateAnnouncementUseCase,
            IRemoveAnnouncementUseCase removeAnnouncementUseCase)
        {
            _getAllAnnouncementUseCase = getAllAnnouncementUseCase;
            _getByIdAnnouncementUseCase = getByIdAnnouncementUseCase;
            _getByOwnerAnnouncementUseCase = getByOwnerAnnouncementUseCase;
            _createAnnouncementUseCase = createAnnouncementUseCase;
            _updateAnnouncementUseCase = updateAnnouncementUseCase;
            _removeAnnouncementUseCase = removeAnnouncementUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _getAllAnnouncementUseCase.Execute();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {
                var result = await _getByIdAnnouncementUseCase.Execute(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("owner/{id}")]
        public async Task<IActionResult> GetByOwnerAsync(Guid id)
        {
            try
            {
                var result = await _getByOwnerAnnouncementUseCase.Execute(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateAnnouncementModel model)
        {
            try
            {
                await _createAnnouncementUseCase.Execute(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateAnnouncementModel model)
        {
            try
            {
                await _updateAnnouncementUseCase.Execute(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{announcementId}")]
        public async Task<IActionResult> RemoveAsync(Guid announcementId)
        {
            try
            {
                await _removeAnnouncementUseCase.Execute(announcementId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}