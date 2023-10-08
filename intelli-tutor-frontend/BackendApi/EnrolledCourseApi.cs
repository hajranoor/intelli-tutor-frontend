using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace intelli_tutor_frontend.BackendApi
{
    internal class EnrolledCourseApi
    {
        public async Task<string> makeEnrollmentInCourse(enrolledCourses enrolledCourses)
        {
            //List<coursesModel> courseList = new List<coursesModel>();
            using (var client = new HttpClient())
            {
                // Serialize the course object to JSON
                string courseJson = JsonConvert.SerializeObject(enrolledCourses);

                // Define the content for the POST request
                var content = new StringContent(courseJson, Encoding.UTF8, "application/json");

                // Send the POST request to the API endpoint
                using (var response = await client.PostAsync("http://localhost:7008/EnrolledCourses", content))
                {
                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }

                    

                    else
                    {
                        // Handle the case where the POST request was not successful
                        // You can throw an exception or handle the error as needed
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }
                }
            }
        }


        public async Task<List<CourseAndEnrolledCourseDTO>> getAllEnrolledCourseData(int studentId)
        {
            List<CourseAndEnrolledCourseDTO> list = new List<CourseAndEnrolledCourseDTO>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/EnrolledCourses/" + studentId ))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<CourseAndEnrolledCourseDTO>>(apiResponse);
                }
            }
            return list;
        }
    }
}
