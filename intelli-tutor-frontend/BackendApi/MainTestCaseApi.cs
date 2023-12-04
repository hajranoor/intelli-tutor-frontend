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
    internal class MainTestCaseApi
    {
        public async Task<List<MainTestCaseModel>> getAllMainTestCaseData(int problemId)
        {
            List<MainTestCaseModel> list = new List<MainTestCaseModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/MainTestCase/" + problemId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<MainTestCaseModel>>(apiResponse);
                }
            }
            return list;
        }
    }
}
