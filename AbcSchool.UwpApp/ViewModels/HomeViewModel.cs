using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.UwpApp.ViewModels
{
    public class HomeViewModel
    {

        public HomeViewModel()
        {
            this.Subjects = new List<Subject>();
            this.Students = new List<Student>();
        }

        public HomeViewModel(List<Subject> subjects, List<Student> students)
        {
            this.Subjects = subjects;
            this.Students = students;
        }

        public List<Subject> Subjects { get; set; }

        public List<Student> Students { get; set; }



    }
}
