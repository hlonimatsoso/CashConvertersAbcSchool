using AbcSchool.Interfaces;
using AbcSchool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;

namespace AbcSchool.UwpApp.Clients
{
    public class AbcSchoolClient : IAbcSchoolClient
    {

        public AbcSchoolClient()
        {

        }

        public async Task AddSubject(Subject subject)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Config.ApiBaseUrl);

                    var json = JsonConvert.SerializeObject(subject);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                  
                    var response = await client.PostAsync("subjects/add", data);

                    string result = response.Content.ReadAsStringAsync().Result;

              
                }
            }
            catch (Exception ex)
            {
                MessageDialog showDialog = new MessageDialog($"API Error ({Config.ApiBaseUrl}/subjects/add) : {ex.Message}. Inner Exception: {ex.InnerException?.Message}");
                showDialog.ShowAsync();
                // display error
                //throw;
            }
        }

        public Task<Student> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Config.ApiBaseUrl);

                    //HTTP GET
                    var responseTask = client.GetAsync("students");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        students = await result.Content.ReadAsAsync<List<Student>>();
                        //readTask.Wait();

                        //students = readTask.Result;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageDialog showDialog = new MessageDialog($"API Error ({Config.ApiBaseUrl}/students) : {ex.Message}. Inner Exception: {ex.InnerException?.Message}");
                showDialog.ShowAsync();
                // display error
                //throw;
            }

            return students;

        }

        //public Task<List<Subject>> GetSubjects()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Subject>> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Config.ApiBaseUrl);
                    //HTTP GET
                    var responseTask = client.GetAsync("subjects");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        subjects = await result.Content.ReadAsAsync<List<Subject>>();
                        //readTask.Wait();

                        //students = readTask.Result;

                    }


                }
            }
            catch (Exception ex)
            {

                MessageDialog showDialog = new MessageDialog($"API Error ({Config.ApiBaseUrl}/subjects) : {ex.Message}. Inner Exception: {ex.InnerException?.Message}");
                showDialog.ShowAsync();
            }

            return subjects;

        }

    }
}
