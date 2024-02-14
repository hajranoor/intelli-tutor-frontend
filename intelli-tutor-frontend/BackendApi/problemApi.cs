using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace intelli_tutor_frontend.BackendApi
{
    internal class ProblemApi
    {
        public async Task<int> insertProblemData(ProblemModel problemModel)
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

        public async Task<ProblemModel> getproblemData(int content_id)
        {
            ProblemModel problem = new ProblemModel();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"http://localhost:7008/Problem/{content_id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    problem = JsonConvert.DeserializeObject<ProblemModel>(apiResponse);
                    Console.WriteLine(problem);
                }
            }
            return problem;
        }

        public async Task<int> getProblemId(int content_id)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync($"http://localhost:7008/Problem/content_id1?content_id1=" + content_id.ToString()))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var responseData = JsonConvert.DeserializeAnonymousType(apiResponse, new { Id = 0 });
                    return responseData.Id;
                }
            }
        }

        public async Task deleteProblemById(int problem_id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:7008/Problem/{problem_id}"))
                {
                    //return response.IsSuccessStatusCode;
                }
            }
        }
    }
}
