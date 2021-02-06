using System;
using System.Net.Http;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/task-asynchronous-programming-model

namespace TASK_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = GetUrlContentLengthAsync();
        }
        public static async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();

            Task<string> getStringTask =
                client.GetStringAsync("https://docs.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents.Length;
        }
        private static void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }
    }
}
