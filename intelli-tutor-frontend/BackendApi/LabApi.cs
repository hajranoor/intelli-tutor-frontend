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
    internal class LabApi
    {
        public async Task<List<labModel>> getAlllabData(int id)
        {
            List<labModel> labList = new List<labModel>();
            Console.WriteLine(id);
            string apiUrl = $"http://localhost:7008/labs/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    labList = JsonConvert.DeserializeObject<List<labModel>>(apiResponse);
                    Console.WriteLine(labList);
                }
            }
            return labList;
        }
    }
}
