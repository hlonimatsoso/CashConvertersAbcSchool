using AbcSchool.Interfaces;
using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Data.Repos
{
    public class StudentsRepo : BaseRepository<Student>, IStudentRepo
    {
        // student specific stuff


       public StudentsRepo(AbcSchoolDbContext context):base(context)
        { }

        public Task<IEnumerable<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
