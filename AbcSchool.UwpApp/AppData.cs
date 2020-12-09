using AbcSchool.Models;
using AbcSchool.UwpApp.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.UwpApp
{
    public static class AppData
    {
        public static AbcSchoolClient Client = new AbcSchoolClient();

        public static List<Subject> Subjects { get; set; }

        public static List<Student> Students { get; set; }

        public static async Task RefreshDataAsync()
        {
            Subjects = await Client.GetSubjects();

            Students = await Client.GetStudents();
        }

    }
}
