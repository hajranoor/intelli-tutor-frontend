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
    internal class MainWeekApi
    {
        public async Task<List<MainWeekModel>> getAllWeekData(int courseId)
        {
            List<MainWeekModel> list = new List<MainWeekModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/MainWeeks/" + courseId ))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<MainWeekModel>>(apiResponse);
                }
            }
            return list;
        }
    }
}
