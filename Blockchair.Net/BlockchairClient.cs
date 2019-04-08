using Blockchair.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Blockchair.Net
{
    public class BlockchairClient
    {
        private readonly string _baseUrl = "https://api.blockchair.com";
        private readonly string _baseCurrency;

        private WebClient wc = new WebClient();
        public BlockchairClient(string currency="bitcoin")
        {
            _baseCurrency = currency;
            
        }

        private const string AddressDashboardEndpoint = "dashboards/address/{}";

        public BlockchairResponse<Dictionary<string, AddressInfo>> GetAddressDashboard(string address)
        {
            var parameters = new Dictionary<string, object>();
            var url = ConstructRequest(GetRequestUrl(FillPathParameter(AddressDashboardEndpoint, address)));
            var result = GetResult<Objects.BlockchairResponse<Dictionary<string, AddressInfo>>>(url);
            return result;
        }
        #region Base methods
        private string FillPathParameter(string path, params string[] values)
        {
            foreach (var value in values)
            {
                var index = path.IndexOf("{}", StringComparison.Ordinal);
                if (index >= 0)
                {
                    path = path.Remove(index, 2);
                    path = path.Insert(index, value);
                }
            }
            return path;
        }
        private string GetRequestUrl(string endpoint)
        {
            string address = $"{_baseUrl}/{_baseCurrency}/{endpoint}";
            return address;
        }
        private string ConstructRequest(string url, Dictionary<string, object> parameters=null)
        {
            if (parameters != null)
            {
                string requestUrl = url + "?" + string.Join("&", parameters.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
                return requestUrl;
            }
            return url;
            
        }
        private T GetResult<T>(string url) where T:new()
        {
            var result = wc.DownloadString(url);
            try
            {
                return JsonConvert.DeserializeObject<T>(result, new JsonSerializerSettings() { Error = ErrorHandler });
            }
            catch (Exception)
            {
                File.AppendAllText("C:\\blockzi\\kunaerrors.txt", result);
                return new T() ;
            }
        }

        private EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> ErrorHandler;
        
        #endregion 
    }
}
