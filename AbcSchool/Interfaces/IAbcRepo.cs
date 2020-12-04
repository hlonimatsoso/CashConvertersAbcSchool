using AbcSchool.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbcSchool.Interfaces
{
    public interface IAbcRepo 
    {
        Task<IEnumerable<Student>> GetStudents();

        Task AddStudent(Student student);

        IEnumerable<Subject> GetSubjects();


    }
}
