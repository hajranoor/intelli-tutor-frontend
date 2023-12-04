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
    internal class courseOfferingapi
    {
        public async Task<List<courseOfferingModel>> getCourseOfferings(int id)
        {
            List<courseOfferingModel> courseOfferingList = new List<courseOfferingModel>();
            string apiUrl = "https://localhost:7008/CourseOffering/" + id;

            using (var client = new HttpClient())
            {
                MessageBox.Show("i am in the water pls help me");

                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/id?id=" + id))
                {

                    string apiResponse = await response.Content.ReadAsStringAsync();    
                    courseOfferingList = JsonConvert.DeserializeObject<List<courseOfferingModel>>(apiResponse);
                    MessageBox.Show(courseOfferingList.ToString());
                }
            }

            return courseOfferingList;
        }
    }
}
