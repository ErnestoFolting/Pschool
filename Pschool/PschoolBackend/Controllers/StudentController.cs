using Microsoft.AspNetCore.Mvc;
using PschoolBackend_BLL.DTOs;
using PschoolBackend_BLL.Services.Interfaces;
using PschoolBackend_DAL.Entities;

namespace PschoolBackend.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _studentService.getStudents();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] StudentDTO studentToAdd)
        {
            await _studentService.addStudent(studentToAdd);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromForm] StudentRedoDTO updateData)
        {
            await _studentService.updateStudent(updateData);
            return Ok();
        }

        [HttpDelete("{studentId}")]

        public async Task<ActionResult> Delete(int studentId)
        {
            await _studentService.deleteStudent(studentId);
            return Ok();
        }
    }
}
