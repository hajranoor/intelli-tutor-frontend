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
    internal class TestCasesApi
    {

        public async Task<int> InsertTestCaseData(TestCaseModel testCaseModel)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(testCaseModel), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/TestCase", content))
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
        public async Task<List<TestCaseModel>> getAllTestCasesData(int problem_id)
        {
            List<TestCaseModel> testCaseList = new List<TestCaseModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/TestCase/" + problem_id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    testCaseList = JsonConvert.DeserializeObject<List<TestCaseModel>>(apiResponse);
                }
            }
            return testCaseList;
        }

        public async void deleteTestCaseByTestCaseId(int test_case_id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:7008/TestCase/{test_case_id}"))
                {
                    //return response.IsSuccessStatusCode;
                }
            }
        }

        public async Task deleteTestCaseByProblemId(int problem_id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:7008/TestCase/DeleteByProblemId/{problem_id}"))
                {
                    //return response.IsSuccessStatusCode;
                }
            }
        }
    }
}
