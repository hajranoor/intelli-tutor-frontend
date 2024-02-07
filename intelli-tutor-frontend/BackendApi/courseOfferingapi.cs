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
using System.Windows.Documents;

namespace intelli_tutor_frontend.BackendApi
{
    internal class CourseOfferingApi
    {
        public async Task<List<CourseOfferingModel>> getCourseOfferings(int id)
        {
            List<CourseOfferingModel> courseOfferingList = new List<CourseOfferingModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/id?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        courseOfferingList = JsonConvert.DeserializeObject<List<CourseOfferingModel>>(apiResponse);
                    }
                }
                return courseOfferingList;
            }
        }

        public async Task<List<MainCourseAndCourseOfferingDTO>> getCourseOfferingForStudent()
        {
            List<MainCourseAndCourseOfferingDTO> mainCourseAndCourseOfferingDTOList = new List<MainCourseAndCourseOfferingDTO>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    mainCourseAndCourseOfferingDTOList = JsonConvert.DeserializeObject<List<MainCourseAndCourseOfferingDTO>>(apiResponse);
                }
            }
            return mainCourseAndCourseOfferingDTOList;
        }

        public async Task<List<MainCourseAndCourseOfferingDTO>> getMyCoursesForTeacher(int id)
        {
            List<MainCourseAndCourseOfferingDTO> courseandcourseofferingDTOList = new List<MainCourseAndCourseOfferingDTO>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/teacherID?teacherId=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseandcourseofferingDTOList = JsonConvert.DeserializeObject<List<MainCourseAndCourseOfferingDTO>>(apiResponse);

                }
            }
            return courseandcourseofferingDTOList;
        }

        //http://localhost:7008/CourseOffering/teacherID?teacherId=1
        //http://localhost:7008/CourseOffering/id?id=" + id


        public async Task<int> InsertCourseOfferingData(CourseOfferingModel courseOffering)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(courseOffering), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/CourseOffering", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = JsonConvert.DeserializeAnonymousType(apiResponse, new { Id = 0 });
                        return responseData.Id;
                    }
                    else
                    {
                        return -1; // Indicate failure
                    }
                }
            }
        }
    }
}
