using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace intelli_tutor_frontend.BackendApi
{
    internal class CourseApi
    {
        public async Task<List<coursesModel>> getAllCourseData()
        {
            List<coursesModel> courseList = new List<coursesModel>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Courses"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseList = JsonConvert.DeserializeObject<List<coursesModel>>(apiResponse);
                }
            }
            return courseList;
        }

    }
}
