using intelli_tutor_frontend.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace intelli_tutor_frontend.BackendApi
{
    internal class UserApi
    {
        public async Task<List<userModel>> checkUserEmailExists(string email)
        {
            List<userModel> userList = new List<userModel>();
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(email), Encoding.UTF8, "application/json");

                using (var response = await client.GetAsync($"http://localhost:7008/user/checkEmail?email={Uri.EscapeDataString(email)}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    userList = JsonConvert.DeserializeObject<List<userModel>>(apiResponse);
                }
            }
            return userList;
        }
        public async Task<int> insertUser(userModel user)
        {
            using (var client = new HttpClient())
            {
                string userJson = JsonConvert.SerializeObject(user);
                var content = new StringContent(userJson, Encoding.UTF8, "application/json");
                using (var response = await client.PostAsync("http://localhost:7008/user", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(apiResponse);
                        return int.Parse(apiResponse);
                    }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        return -1;
                    }
                }
            }

        }
        public async void DeleteUserById(int userId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:7008/user/{userId}"))
                {
                    //return response.IsSuccessStatusCode;
                }
            }
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
