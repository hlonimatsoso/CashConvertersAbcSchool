using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Interfaces
{
    public interface ISubjectRepo : IGenericRepo<Subject>
    {
        Task<IEnumerable<Subject>> GetAllSubjects();

    }
}
