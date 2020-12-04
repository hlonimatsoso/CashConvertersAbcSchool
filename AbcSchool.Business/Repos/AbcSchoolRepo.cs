using AbcSchool.Data;
using AbcSchool.Interfaces;
using AbcSchool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Business.Repos
{
    public class AbcSchoolRepo : IAbcRepo
    {

        private readonly AbcSchoolDbContext _db;

        public AbcSchoolRepo(AbcSchoolDbContext db)
        {
            this._db = db;
        }

        public async Task AddStudent(Student student)
        {
           await this._db.Students.AddAsync(student);
           await this._db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await this._db.Students.ToListAsync();
        }

        public IEnumerable<Subject> GetSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
