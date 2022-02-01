using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CardTracker.Models;

namespace CardTracker.Data
{
    public class EbayProxy
    {
        public EbayProxy()
        {
        }

        HttpClient client = new HttpClient();

        public async Task<List<Product>> GetProductsAsync(string query)
        {
            //Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Product>();
            }

            return product;
        }

    }
}
