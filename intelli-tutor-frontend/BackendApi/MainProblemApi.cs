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
    internal class MainProblemApi
    {
        public async Task<List<MainProblemsModel>> getAllMainProblemData(int contentId)
        {
            List<MainProblemsModel> list = new List<MainProblemsModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/MainProblems/" + contentId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<MainProblemsModel>>(apiResponse);
                }
            }
            return list;
        }
    }
}
