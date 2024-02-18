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
using System.Windows;
using Google.Apis.PeopleService.v1.Data;

namespace intelli_tutor_frontend.BackendApi
{
    internal class EnrolledCourseApi
    {
        public async Task<string> makeEnrollmentInCourse(EnrolledCourses enrolledCourses)
        {
            using (var client = new HttpClient())
            {
                string courseJson = JsonConvert.SerializeObject(enrolledCourses);
                var content = new StringContent(courseJson, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync("http://localhost:7008/EnrolledCourses", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return apiResponse;
                    }
                }
            }
        }

        public async Task<bool> checkCourseCapacity(int courseOfferingID)
        {
            bool ans;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/checkCapacity/" + courseOfferingID))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        ans =  true;
                    }
                    else
                    {
                        ans = false;
                    }
                }
            }
            return ans;
        }
                       // using (var response = await client.GetAsync("http://localhost:7008/CourseOffering/teacherID?teacherId=" + id))



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

        public async Task<bool> deleteEnrollment(int enrollment_id)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.DeleteAsync("http://localhost:7008/EnrolledCourses/"+ enrollment_id))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
