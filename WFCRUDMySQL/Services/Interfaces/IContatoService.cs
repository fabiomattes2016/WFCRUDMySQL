using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCRUDMySQL.Model;

namespace WFCRUDMySQL.Services.Interfaces
{
    public interface IContatoService
    {
        [Get("/contato")]
        Task<List<ContatoResponse>> GetContatos();

        [Get("/contato/{id}")]
        Task<ContatoResponse> GetContatoById(int id);

        [Get("/contato/pesquisa/{parametro}")]
        Task<List<ContatoResponse>> GetContatosByParametro(string? parametro);

        [Post("/contato")]
        Task<ContatoResponse> PostContato(Contato contato);

        [Put("/contato/{id}")]
        Task PutContato(int? id, Contato contato);

        [Delete("/contato/{id}")]
        Task DeleteContato(int? id);
    }
}
