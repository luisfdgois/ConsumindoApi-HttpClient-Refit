using System.Net.Http;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;

namespace TesteRequisitoApiNotifications.WebServices.HttpClientLibrary
{
    public interface NotificationService
    {
        Task<HttpResponseMessage> AdicionarAluno(AlunoCadastro alunoCadastro);
        Task<HttpResponseMessage> ObterAlunos();
    }
}
