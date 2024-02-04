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
    internal class WeekApi
    {

        public async Task<int> InsertWeekData(WeekModel week)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(week), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/Week", content))
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

        public async Task<List<WeekModel>> getAllWeekData(int course_offering_Id)
        {
            List<WeekModel> list = new List<WeekModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Week/"+ course_offering_Id + "?course_offering_Id=" + course_offering_Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<WeekModel>>(apiResponse);
                }
            }
            return list;
        }

        public async Task<List<WeekModel>> getAllMainWeekDataByCourseOfferingId(int course_offering_Id)
        {
            List<WeekModel> list = new List<WeekModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Week/" + course_offering_Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<WeekModel>>(apiResponse);
                }
            }
            return list;
        }
    }
}
