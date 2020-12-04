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
       private readonly IAbcRepo _db;
        public StudentsController(IAbcRepo db)
        {
            this._db = db;
        }

        [HttpGet("students")]
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await this._db.GetStudents();
        }

        [HttpPost("student")]

        public async Task AddStudent(Student student)
        {
            await this._db.AddStudent(student);
            
        }
    }
}
