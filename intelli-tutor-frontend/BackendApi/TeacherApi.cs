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
    }
}
