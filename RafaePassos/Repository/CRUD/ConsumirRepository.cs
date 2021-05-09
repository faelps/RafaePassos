using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace RafaePassos.Repository.CRUD
{
    public class ConsumirRepository
    {
        protected async Task<TEntity> Enviar<TEntity>(Uri uri, string rota, Method method, object body) where TEntity : class
        {
            RestClient cliente = new RestClient(uri);

            var request = new RestRequest(rota, method) { RequestFormat = DataFormat.Json };

            request.AddJsonBody(body);

            var response = await cliente.ExecuteTaskAsync(request);

            var respotaDaApi = await Task.FromResult(JsonConvert.DeserializeObject<TEntity>(response.Content));

            return respotaDaApi;
        }

        protected static async Task<TEntity> Buscar<TEntity>(Uri uri, string rota, Method method) where TEntity : class
        {
            RestClient cliente = new RestClient(uri);

            var request = new RestRequest(rota, method) { RequestFormat = DataFormat.Json };

            var response = await cliente.ExecuteAsync(request);

            var respotaDaApi = await Task.FromResult(JsonConvert.DeserializeObject<TEntity>(response.Content));

            return respotaDaApi;
        }
    }
}
