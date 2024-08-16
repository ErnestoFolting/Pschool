using Microsoft.AspNetCore.Mvc;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend.Controllers
{
    [ApiController]
    [Route("api/parents")]
    public class ParentController : ControllerBase
    {
        private readonly IParentService _parentService;
        public ParentController(IParentService parentservice)
        {
            _parentService = parentservice;
        }

        [HttpGet]
        public async Task<IEnumerable<ParentDTO>> Get()
        {
            return await _parentService.getParents();
        }

        [HttpPost]
        public async Task<ActionResult> Post(ParentDTO parentToAdd)
        {
            await _parentService.addParent(parentToAdd);
            return Ok();
        }

        [HttpPut("{parentId}")]
        public async Task<ActionResult> Update(ParentRedoDTO updateData, int parentId)
        {
            await _parentService.updateParent(updateData, parentId);
            return Ok();
        }

        [HttpDelete("{parentId}")]

        public async Task<ActionResult> Delete(int parentId)
        {
            await _parentService.deleteParent(parentId);
            return Ok();
        }
    }
}
