using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;
using TesteRequisitoApiNotifications.WebServices.HttpClientLibrary;

namespace TesteRequisitoApiNotifications.Services
{
    public class ServiceAlunoImp : ServiceAluno
    {
        private readonly NotificationService _apiNotification;

        public ServiceAlunoImp(NotificationService apiNotification)
        {
            _apiNotification = apiNotification;
        }

        public async Task AdicionarAluno(AlunoCadastro alunoCadastro)
        {
            var result = await _apiNotification.AdicionarAluno(alunoCadastro);

            if (!result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                throw new Exception(content);
            }
        }

        public async Task<IEnumerable<AlunoViewModel>> ListarAlunos()
        {
            var result = await _apiNotification.ObterAlunos();

            var content = await result.Content.ReadAsStringAsync();
            
            if (!result.IsSuccessStatusCode)
            {
                throw new Exception(content);
            }

            var alunos = JsonSerializer.Deserialize<IEnumerable<AlunoViewModel>>(content);

            return alunos;
        }
    }
}
