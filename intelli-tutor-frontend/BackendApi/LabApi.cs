﻿using intelli_tutor_frontend.Model;
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
    internal class LabApi
    {
        public async Task<List<LabModel>> getAlllabData(int id)
        {
            List<LabModel> labList = new List<LabModel>();
            Console.WriteLine(id);
            string apiUrl = $"http://localhost:7008/labs/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();


                    labList = JsonConvert.DeserializeObject<List<LabModel>>(apiResponse);
                    Console.WriteLine(labList);
                }
            }
            return labList;
        }
    }
}
