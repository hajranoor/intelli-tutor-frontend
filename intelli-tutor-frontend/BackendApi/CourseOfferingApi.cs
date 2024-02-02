using intelli_tutor_frontend.Model;
using intelli_tutor_frontend.TeacherSide;
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
    internal class CourseOfferingApi
    {
        public async Task<List<CourseOfferingModel>> getCourseOfferings(int id)
        {
            List<CourseOfferingModel> courseOfferingList = new List<CourseOfferingModel>();
            string apiUrl = "https://localhost:7008/CourseOffering/" + id;

            using (var client = new HttpClient())
            {

                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/id?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(apiResponse);
                    if (response.IsSuccessStatusCode)
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        courseOfferingList = JsonConvert.DeserializeObject<List<CourseOfferingModel>>(apiResponse);
                        //MessageBox.Show(courseOfferingList.ToString());
                    }
                }

                return courseOfferingList;
            }
        }
        public async Task<int> InsertCourseOfferingData(CourseOfferingModel courseOffering)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(courseOffering), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/CourseOffering", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(apiResponse);
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string


                        // Deserialize the JSON response to an anonymous type containing the ID
                        var responseData = JsonConvert.DeserializeAnonymousType(apiResponse, new { Id = 0 });

                        // Return the ID
                        return responseData.Id;
                    }
                    else
                    {
                        // Handle non-success status codes if needed
                        return -1; // Indicate failure
                    }
                }
            }
        }
    }
}
