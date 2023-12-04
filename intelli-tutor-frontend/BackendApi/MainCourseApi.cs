﻿using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace intelli_tutor_frontend.BackendApi
{
    internal class MainCourseApi
    {
        public async Task<List<MainCourse>> getAvailableCourse()
        {
            List<MainCourse> courseList = new List<MainCourse>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/MainCourse"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    courseList = JsonConvert.DeserializeObject<List<MainCourse>>(apiResponse);
                }
            }
            return courseList;
        }
    }
}