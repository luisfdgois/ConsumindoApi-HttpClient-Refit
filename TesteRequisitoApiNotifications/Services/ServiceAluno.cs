using System.Collections.Generic;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;

namespace TesteRequisitoApiNotifications.Services
{
    public interface ServiceAluno
    {
        Task AdicionarAluno (AlunoCadastro alunoCadastro);
        Task<IEnumerable<AlunoViewModel>> ListarAlunos();
    }
}
