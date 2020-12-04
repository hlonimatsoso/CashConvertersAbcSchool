using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcSchool.Interfaces
{
    public interface IAbcRepo<T> where T : class
    {
        IEnumerable<Student> GetStudents();

        IEnumerable<Subject> GetSubjects();


    }
}
