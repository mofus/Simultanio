using ModernHttpClient;
using System.Net.Http;
using System.Threading.Tasks;

namespace Simultanio
{
    public static class MyClass
    {
        public const string Hello = "Hello Simultanio";

        public static int Adder(int a, int b)
        {
            return a + b;
        }

		public static string GetPage()
		{
			// DownloadAsyncWithRxAndReturnFromWorkerThread
			return DownloadPageAsync().Result;
		}

		public static HttpClient GetHttpClient()
		{
			return new HttpClient(new NativeMessageHandler());
		}

		static async Task<string> DownloadPageAsync()
		{
            var direction = await GetHttpClient().GetStringAsync("http://checkip.dyndns.org/").ConfigureAwait(false);
            //Search for the ip in the html
            int first = direction.IndexOf ("Address: ", System.StringComparison.Ordinal) + 9;
            int last = direction.LastIndexOf ("</body>", System.StringComparison.Ordinal);
            direction = direction.Substring(first, last - first);
            return direction;
		}
    }
}