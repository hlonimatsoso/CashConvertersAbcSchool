using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcSchool.Interfaces
{
    public interface ISubjectsRepo
    {
        IEnumerable<Subject> GetSubjects();

    }
}
