using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.UwpApp.ViewModels
{
   public class SubjectsViewModel
    {

        public SubjectsViewModel(List<Subject> subjects)
        {
            this.Subjects = subjects;
        }

        public List<Subject> Subjects { get; set; }

    }
}
