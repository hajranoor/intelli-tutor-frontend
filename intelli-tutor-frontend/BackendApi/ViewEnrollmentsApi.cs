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
    internal class ViewEnrollmentsApi
    {

        public async Task<List<ViewEnrollmentsDTO>> getAllEnrollments(int teacherId, int courseofferingId)
        {
            List<ViewEnrollmentsDTO> list = new List<ViewEnrollmentsDTO>();
            using (var client = new HttpClient())
            {
                string apiUrl = $"http://localhost:7008/ViewEnrollments/teacherid/{teacherId}/courseofferingid/{courseofferingId}";

                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<ViewEnrollmentsDTO>>(apiResponse);
                }
            }
            return list;
        }





        public async Task<EnrolledCourses> ChangeEnrollmentStatus(int studentId, int courseofferingId, int teacherId)
        {
            EnrolledCourses result = new EnrolledCourses();
            using (var client = new HttpClient())
            {
                string apiUrl = $"http://localhost:7008/ViewEnrollments/studentid/{studentId}/courseofferingid/{courseofferingId}/teacherid/{teacherId}";


                using (var response = await client.PostAsync(apiUrl,null)) 
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<EnrolledCourses>(apiResponse);
                }
            }
            return result;


        }




    }
}
