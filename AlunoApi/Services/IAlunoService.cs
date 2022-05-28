using AlunoApi.Controllers.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlunoApi.Services
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAluno();
        Task<Aluno> GetAluno(int id);
        Task<IEnumerable<Aluno>> GetAlunosByNome(string nome);
        Task CreateAluno(Aluno aluno);
        Task UpdateAluno(Aluno aluno);
        Task DeleteAluno(Aluno aluno);
    }
}
