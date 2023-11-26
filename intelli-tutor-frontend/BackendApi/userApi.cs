using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace intelli_tutor_frontend.BackendApi
{
    internal class userApi
    {
        public async Task<List<problemModel>> getAllproblemData(int id)
        {
            List<problemModel> problemList = new List<problemModel>();
            string apiUrl = $"http://localhost:7008/Problem/{id}";
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    problemList = JsonConvert.DeserializeObject<List<problemModel>>(apiResponse);
                    Console.WriteLine(problemList);
                }
            }
            return problemList;


        }

        public async Task<string> checkUserExists(Model.userModel u)
        {
            string Response;

            Console.WriteLine(u);
            using (var client = new HttpClient())
            {
                string apiUrl = $"http://localhost:7008/user/checkuser?username={Uri.EscapeDataString(u.username)}&password={Uri.EscapeDataString(u.pass_word)}";

                using (var response = await client.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    Response = JsonConvert.DeserializeObject<string>(apiResponse);
                    Console.WriteLine(Response);
                }
            }
            return Response;
        }



       





    }
}

