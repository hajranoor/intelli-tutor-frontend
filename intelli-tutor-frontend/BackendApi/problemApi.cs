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
    internal class ProblemApi
    {
        public async Task<int> InsertProblemData(ProblemModel problemModel)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(problemModel), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/Problem", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var responseData = JsonConvert.DeserializeAnonymousType(apiResponse, new { Id = 0 });
                        return responseData.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        //--------------------------------------------------------------------
        public async Task<List<ProblemModel>> getAllproblemData(int id)
        {
            List<ProblemModel> problemList = new List<ProblemModel>();
            string apiUrl = $"http://localhost:7008/Problem/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    problemList = JsonConvert.DeserializeObject<List<ProblemModel>>(apiResponse);
                    Console.WriteLine(problemList);
                }
            }
            return problemList;
        }
    }
}
