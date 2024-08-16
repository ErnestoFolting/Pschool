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
        public async Task<IEnumerable<StudentRedoDTO>> Get()
        {
            return await _studentService.getStudents();
        }

        [HttpPost]
        public async Task<ActionResult> Post(StudentDTO studentToAdd)
        {
            await _studentService.addStudent(studentToAdd);
            return Ok();
        }

        [HttpPut("{studentId}")]
        public async Task<ActionResult> Update(StudentRedoDTO updateData, int studentId)
        {
            await _studentService.updateStudent(updateData, studentId);
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
