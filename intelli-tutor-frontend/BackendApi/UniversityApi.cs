using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace intelli_tutor_frontend.BackendApi
{
    internal class UniversityApi
    {
        public async Task<List<string>> getAllUniversity()
        {
            List<string> universityList = new List<string>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/university"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    universityList = JsonConvert.DeserializeObject<List<string>>(apiResponse);
                }
            }
            return universityList;
        }

        public async Task<int> getUniversityId(string name)
        {
            int id = 0;
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(name), Encoding.UTF8, "application/json");

                using (var response = await client.GetAsync($"http://localhost:7008/university/getId?name={Uri.EscapeDataString(name)}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    id = JsonConvert.DeserializeObject<int>(apiResponse);
                }
            }
            return id;
        }
    }
}
