using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretninte_Class.facebook
{
    class FacebookClient : IFacebookClient
    {
        //public readonly HttpClient = _httpClient;

        public Task<T> GetAsync<T>(string accesToken, string endPoint, string args = null)
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(string accesPoint, string endPoint, object data, string args = null)
        {
            throw new NotImplementedException();
        }
    }
    public interface IFacebookClient
    {
        Task<T> GetAsync<T>(string accesToken, string endPoint, string args = null);
        Task PostAsync(string accesPoint, string endPoint, object data, string args = null);
    }
}
