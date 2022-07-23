using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCRUDMySQL.Model;
using WFCRUDMySQL.Services.Interfaces;

namespace WFCRUDMySQL.Services
{
    public class ContatoService
    {
        string BASEURL = "https://apicrudmysql.azurewebsites.net/api/v1";

        public async Task<List<ContatoResponse>> GetContatosService()
        {
            try
            {
                var contatos = await RestService.For<IContatoService>(BASEURL).GetContatos();
                return contatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public async Task<ContatoResponse> GetContatoById(int id)
        //{
        //    return NotImplementedException;
        //}

        public async Task<List<ContatoResponse>> GetContatoByParametroService(string? parametro)
        {
            try
            {
                var contatos = await RestService.For<IContatoService>(BASEURL).GetContatosByParametro(parametro);
                return contatos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ContatoResponse> PostContatoService(Contato contato)
        {
            try
            {
                var result = await RestService.For<IContatoService>(BASEURL).PostContato(contato);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task PutContatoService(int? id, Contato contato)
        {
            try
            {
                await RestService.For<IContatoService>(BASEURL).PutContato(id, contato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteContatoService(int? id)
        {
            try
            {
                await RestService.For<IContatoService>(BASEURL).DeleteContato(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
