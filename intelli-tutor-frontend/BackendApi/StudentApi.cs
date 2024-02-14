using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.BackendApi
{
    internal class StudentApi
    {
        public async Task<string> insertStudentData(StudentModel student)
        {
            using (var client = new HttpClient())
            {
                string studentJson = JsonConvert.SerializeObject(student);
                var content = new StringContent(studentJson, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync("http://localhost:7008/student", content))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }
                }
            }
        }
        public async Task<StudentModel> getStudentByUserId(int user_id)
        {
            StudentModel student = new StudentModel();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/student/getStudent/" + user_id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    student = JsonConvert.DeserializeObject<StudentModel>(apiResponse);
                }
            }
            return student;
        }
    }
}
