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
    internal class ContentApi
    {
        public async Task<int> insertContentData(ContentModel contentModel)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(contentModel), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/Content", content))
                {
                    MessageBox.Show(response.StatusCode.ToString());
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

        public async Task<List<ContentModel>> getContentByWeekId(int weekId)
        {
            List<ContentModel> list = new List<ContentModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Content/" + weekId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<ContentModel>>(apiResponse);
                }
            }
            return list;
        }

        public async Task deleteContentById(int content_id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:7008/Content/{content_id}"))
                {
                    //return response.IsSuccessStatusCode;
                }
            }
        }
    }
}
