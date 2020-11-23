using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;

namespace TesteRequisitoApiNotifications.WebServices.RefitLibrary
{
    public interface NotificationService
    {
        [Get("/weatherforecast")]
        Task<HttpResponseMessage> ObterAlunos();

        [Post("/weatherforecast")]
        Task<HttpResponseMessage> AdicionarAluno([Body] AlunoCadastro alunoCadastro);
    }
}
