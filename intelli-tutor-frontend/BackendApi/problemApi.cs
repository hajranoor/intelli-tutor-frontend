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
    internal class problemApi
    {
        public async Task<List<problemModel>> getAllproblemData(int id)
        {
            List<problemModel> problemList = new List<problemModel>();
            Console.WriteLine(id);
            string apiUrl = $"http://localhost:7008/Problem/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    problemList = JsonConvert.DeserializeObject<List<problemModel>>(apiResponse);
                    Console.WriteLine(problemList);
                }
            }
            return problemList;
        }
    }
}
