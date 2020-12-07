using AbcSchool.Data;
using AbcSchool.Interfaces;
using AbcSchool.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcSchool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
       private readonly IStudentRepo _db;
        public StudentsController(IStudentRepo db)
        {
            this._db = db;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await this._db.GetAllAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<Student> GetStudent(int id)
        {
            return await this._db.GetByIDAsync(id);
        }

        [HttpPost("add")]

        public async Task AddStudent(Student student)
        {
            await this._db.InsertAsync(student);
            
        }


        [HttpPost("update")]

        public void UpdateStudent(Student student)
        {
             this._db.Update(student);

        }


        [HttpDelete("{id:int}")]

        public async Task DeleteStudent(int id)
        {
            await this._db.DeleteAsync(id);

        }
    }
}
