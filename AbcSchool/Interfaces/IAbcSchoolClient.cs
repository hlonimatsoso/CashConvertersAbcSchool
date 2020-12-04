﻿using AbcSchool.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AbcSchool.Interfaces
{
    public interface IAbcSchoolClient
    {
        Task<List<Student>> GetStudents();


    }
}
