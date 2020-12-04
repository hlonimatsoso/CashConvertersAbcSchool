using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.UwpApp.ViewModels
{
    public class MainPageViewModel
    {

        public MainPageViewModel()
        {
            this.Subjects = new List<Subject>();
            this.Students = new List<Student>();
        }

        public List<Subject> Subjects { get; set; }

        public List<Student> Students { get; set; }



    }
}
