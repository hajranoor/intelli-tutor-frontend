using intelli_tutor_frontend.Model;
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
    internal class NotificationApi
    {
        public async Task<List<Notification>> getAllStudentNotifications(int studentId)
        {
            List<Notification> list = new List<Notification>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:7008/Notification/studentId?studentId=" + studentId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<Notification>>(apiResponse);
                }
            }
            return list;
        }

        public async Task<bool> ChangeNotificationStatusToRead(Notification notification)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(notification), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync($"http://localhost:7008/Notification/{notification.notification_id}", content))
                {
                    return response.IsSuccessStatusCode;
                }
            }
        }

        public async Task<bool> insertNotification(Notification notification)
        {
            using (var client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(notification), Encoding.UTF8, "application/json");

                using (var response = await client.PostAsync("http://localhost:7008/Notification", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
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
