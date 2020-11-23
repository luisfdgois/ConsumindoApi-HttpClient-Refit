using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;

namespace TesteRequisitoApiNotifications.WebServices.HttpClientLibrary
{
    public class NotificationServiceImp : NotificationService
    {
        private const string uri = "http://localhost:44363/weatherforecast";

        public async Task<HttpResponseMessage> AdicionarAluno(AlunoCadastro alunoCadastro)
        {
            using (HttpClient client = new HttpClient())
            {
                var body = JsonSerializer.Serialize(alunoCadastro);

                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(uri),
                    Method = HttpMethod.Post,
                    Content = new StringContent(body, Encoding.UTF8, "application/json")
                };

                var response = await client.SendAsync(request);
                
                return response;
            }
        }

        public async Task<HttpResponseMessage> ObterAlunos()
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(uri),
                    Method = HttpMethod.Get
                };

                var response = await client.SendAsync(request);

                return response;
            }
        }
    }
}
