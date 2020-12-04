using AbcSchool.Interfaces;
using AbcSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.UwpApp.Clients
{
    public class AbcSchoolClient : IAbcSchoolClient
    {
        public async Task<List<Student>> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:5000/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("students/students");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        students = await result.Content.ReadAsAsync<List<Student>>();
                        //readTask.Wait();

                        //students = readTask.Result;

                    }

                    return students;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
