using intelli_tutor_frontend.Model;
using MVCproject.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.BackendApi
{
    internal class TeacherApi
    {
        public async Task<string> insertTeacherData(TeacherModel teacher)
        {
            using (var client = new HttpClient())
            {
                string teacherJson = JsonConvert.SerializeObject(teacher);
                var content = new StringContent(teacherJson, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync("http://localhost:7008/teacher", content))
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

        public async Task<List<UserAndTeacherDTO>> getTeacher(int teacher_id)
        {
            List<UserAndTeacherDTO> list = new List<UserAndTeacherDTO>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/teacher/" + teacher_id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<UserAndTeacherDTO>>(apiResponse);
                }
            }
            return list;
        }

        public async Task<TeacherModel> getTeacherByUserId(int user_id)
        {
            TeacherModel teacher = new TeacherModel();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/teacher/getTeacher/"  + user_id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    teacher = JsonConvert.DeserializeObject<TeacherModel>(apiResponse);
                }
            }
            return teacher;
        }
    }
}
