using Microsoft.AspNetCore.Mvc;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend.Controllers
{
    [ApiController]
    [Route("api/parentcouples")]
    public class ParentCoupleController : ControllerBase
    {
        private readonly IParentCoupleService _parentCoupleService;
        public ParentCoupleController(IParentCoupleService parentCoupleservice)
        {
            _parentCoupleService = parentCoupleservice;
        }

        [HttpGet]
        public async Task<IEnumerable<ParentCouple>> Get()
        {
            return await _parentCoupleService.getParentCouples();
        }

        [HttpPost]
        public async Task<ActionResult> Post(ParentCoupleDTO parentCoupleToAdd)
        {
            await _parentCoupleService.addParentCouple(parentCoupleToAdd);
            return Ok();
        }
    }
}
