using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            try
            {

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
                //client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
                //client.DefaultRequestHeaders.Add("Content-Type", );
                client.DefaultRequestHeaders.Add("api_client", "423e4744e41c496e95e149891ad2717b");
                client.DefaultRequestHeaders.Add("apikey", "3b10cba1-852b-ec11-9103-ac1f6b0a9f7d");
                client.DefaultRequestHeaders.Add("Cookie", "NSC_UFF_BQJ_443=ffffffff099d00bc45525d5f4f58455e445a4a42378b");
                client.DefaultRequestHeaders.Add("apikey", "3b10cba1-852b-ec11-9103-ac1f6b0a9f7d");
                client.DefaultRequestHeaders.Add("grant_type", "password");
                client.DefaultRequestHeaders.Add("api_client", "085a9b3d95d24860a7047572516fc5bc");
                



                var stringTask = client.GetStringAsync("https://api.edgeestimator.com/12.8/token");


                var msg = await stringTask;
                Console.Write(msg);
            }
            catch (Exception e)
            {

                Console.WriteLine("You had an error: " + e); ;
            }
        }


    }

    
}