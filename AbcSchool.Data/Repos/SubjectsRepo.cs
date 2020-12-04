using AbcSchool.Interfaces;
using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Data.Repos
{
    public class SubjectsRepo : BaseRepository<Subject>, ISubjectRepo
    {
        // student specific stuff


       public SubjectsRepo(AbcSchoolDbContext context):base(context)
        { }

        public Task<IEnumerable<Subject>> GetAllSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
