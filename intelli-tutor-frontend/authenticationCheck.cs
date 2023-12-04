using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Google.Apis.Auth;
//using Google.Apis.Plus.v1;
//using Google.Apis.Plus.v1.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.PeopleService.v1;
using System.IO;
using Google.Apis.PeopleService.v1.Data;

namespace intelli_tutor_frontend
{
    public partial class authenticationCheck : Form
    {

        GoogleAuthorizationCodeFlow flow;


        public authenticationCheck()
        {
            InitializeComponent();
        }


        private void authenticationCheck_Load(object sender, EventArgs e)
        {
            
            //SendSecurityCodeToEmail("hajranoor22012bfgnbfngk", "78789");
            googleAuthenticationAsync();
        }

        private void SendSecurityCodeToEmail(string EmailAddress, string securityCode)
        {
            string recipientEmail = "hajranoor221@gmail.com";
            string subject = "App Registration Security Code";
            string body = "45674";

            if (IsValidEmail(recipientEmail))
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;

                string senderEmail = "hajranoor2003@gmail.com";
                string senderPassword = "eeub zplr lxdn ixxi";

                using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    client.EnableSsl = true;

                    using (MailMessage message = new MailMessage(senderEmail, recipientEmail))
                    {
                        message.Subject = "Security code for ur app";
                        message.Body = $"Your security code is : {4567}";
                        client.Send(message);

                        MessageBox.Show("email sent");
                    }
                }
            }
        }

        private bool IsValidEmail(string recipientEmail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(recipientEmail);
                return addr.Address == recipientEmail;
            }

            catch
            {
                return false;
            }
        }

        public async Task googleAuthenticationAsync()
        {
            string cliendId = "924160782241-h2gen2ro0nndcei12ffrvehasd2e109l.apps.googleusercontent.com";
            string clientSecret = "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";
            //string cliendId = "924160782241-65okljt3khgqd3rpttvf10605ugmv87j.apps.googleusercontent.com";
            //string clientSecret = "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";
            string credentialsPath = "D:\\credentials.json";
            string[] scopes = { PeopleServiceService.Scope.UserinfoProfile, PeopleServiceService.Scope.UserinfoEmail };

            this.flow = new GoogleAuthorizationCodeFlow(
                new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = cliendId,
                        ClientSecret = clientSecret
                    },
                    //Scopes = new[] { PlusService.Scope.UserinfoEmail, PlusService.Scope.UserinfoProfile },
                    Scopes = scopes
                }) ;

            



            string authUrl = flow.CreateAuthorizationCodeRequest("urn:ietf:wg:oauth:2.0:oob").Build().ToString();
            MessageBox.Show($"Please visit {authUrl} and enter the authorization code");
            label1.Text = authUrl;
            textBox2.Text = authUrl;
            //string authCode = "take input from user";
            string authCode = textBox1.Text;
            MessageBox.Show($"{authCode}");
            //label1.Text = authCode;

            //try
            //{
                //TokenResponse token = await flow.ExchangeCodeForTokenAsync(null, authCode, "urn:ietf:wg:oauth:2.0:oob", CancellationToken.None);

                //PlusService plusService = new PlusService(new BaseClientService.Initializer
                //{
                    //HttpClientInitializer = new UserCredential(flow, "me", token),
                    //ApplicationName = "YourAppName",
                //}

                //);

                //Person me = plusService.People.Get("me").Execute();
                //MessageBox.Show($"User ID: {me.Id}");
                //MessageBox.Show($"User ID: {me.Id}");
                //MessageBox.Show($"Display Name: {me.DisplayName}");
            //}

            //catch (TokenResponseException ex )
            //{
                //Console.WriteLine($"Error: {ex.Error}");
                //nsole.WriteLine($"Description: {ex.ErrorDescription}");
                //sole.WriteLine($"Uri: {ex.Response?.ResponseUri}");

                
            //}
            //TokenResponse token = await flow.ExchangeCodeForTokenAsync(null, authCode, "urn:ietf:wg:oauth:2.0:oob", CancellationToken.None);

            //PlusService plusService = new PlusService(new BaseClientService.Initializer
            //{
                //HttpClientInitializer = new UserCredential(flow, "me", token),
                //ApplicationName = "YourAppName",
            //}

                //);

           // Person me = plusService.People.Get("me").Execute();
            //Console.WriteLine($"User ID: {me.Id}") ;
            //MessageBox.Show($"User ID: {me.Id}");
            //MessageBox.Show($"Display Name: {me.DisplayName}");





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            string authCode = textBox1.Text;

            try
            {
                TokenResponse token = await this.flow.ExchangeCodeForTokenAsync(null, authCode, "urn:ietf:wg:oauth:2.0:oob", CancellationToken.None);

                //PlusService plusService = new PlusService(new BaseClientService.Initializer
                //{
                    //HttpClientInitializer = new UserCredential(flow, "me", token),
                    //ApplicationName = "YourAppName",
                //}

               // );

                //Person me = plusService.People.Get("me").Execute();
                //MessageBox.Show($"User ID: {me.Id}");
                //MessageBox.Show($"User ID: {me.Id}");
                //MessageBox.Show($"Display Name: {me.DisplayName}");


                UserCredential credential = new UserCredential(this.flow, "user", token);

                PeopleServiceService peopleService = new PeopleServiceService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "YourAppName"
                });
                string personFields = "names";

                PeopleResource.GetRequest request = peopleService.People.Get("people/me");
                request.PersonFields = personFields;
                Person me = request.Execute();

                MessageBox.Show($"Display Name: {me.Names?.FirstOrDefault()?.DisplayName}");

                //Person me = peopleService.People.Get("people/me").Execute();
                //MessageBox.Show($"Display Name: {me.Names.ToString()}");

            }
            catch (TokenResponseException ex)
            {
                Console.WriteLine($"Error: {ex.Error}");
                //nsole.WriteLine($"Description: {ex.ErrorDescription}");
                //sole.WriteLine($"Uri: {ex.Response?.ResponseUri}");


            }


        }
    }
}
