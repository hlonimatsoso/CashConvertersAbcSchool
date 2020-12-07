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
    public class SubjectsController : ControllerBase
    {
        public ISubjectRepo _repo;

        public SubjectsController(ISubjectRepo repo)
        {
            this._repo = repo;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Subject>> GetAllSubjects()
        {

            return await _repo.GetAllAsync();

        }


        [HttpPost("add")]

        public async Task AddSubject(Subject subject)
        {
            await this._repo.InsertAsync(subject);

        }
    }
}
