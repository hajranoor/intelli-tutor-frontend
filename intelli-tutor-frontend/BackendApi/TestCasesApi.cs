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
        public async Task<List<testCaseModel>> getAllTestCasesData(int problemId)
        {
            List<testCaseModel> testCaseList = new List<testCaseModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/testcases/" + problemId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    testCaseList = JsonConvert.DeserializeObject<List<testCaseModel>>(apiResponse);
                }
            }
            return testCaseList;
        }
    }
}
