using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Interfaces
{
    public interface IStudentRepo: IGenericRepo<Student> 
    {
        Task<IEnumerable<Student>> GetAllStudents();

    }
}
