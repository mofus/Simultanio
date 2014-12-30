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
			return await GetHttpClient().GetStringAsync("http://google.com")
				.ConfigureAwait(false);
		}
    }
}