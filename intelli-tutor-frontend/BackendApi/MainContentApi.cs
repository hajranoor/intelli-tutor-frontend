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
    internal class MainContentApi
    {
        public async Task<List<MainContentModel>> getMainContentByWeekId(int weekId)
        {
            List<MainContentModel> list = new List<MainContentModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/MainContent/" + weekId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<MainContentModel>>(apiResponse);

                }
            }
            return list;
        }

        //public async Task<List<MainContentModel>> getSuperAdminCourseContentByWeekId(int weekId)
        //{
        //    List<MainContentModel> list = new List<MainContentModel>();
        //    using (var client = new HttpClient())
        //    {
        //        using (var response = await client.GetAsync("http://localhost:7008/MainContent/" + weekId))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            list = JsonConvert.DeserializeObject<List<MainContentModel>>(apiResponse);
        //        }
        //    }
        //    return list;
        //}
    }
}
