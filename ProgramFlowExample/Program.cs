using System;
using System.Net;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            var getWebPage = GetWebPage(new Uri("http://www.spitzer.caltech.edu/uploaded_files/images/0006/3134/ssc2008-11a13_Huge.jpg"));

            Console.WriteLine("Passed the get line, status {0}", getWebPage.IsCompleted);

            Console.WriteLine(getWebPage.Result.Length);

            Console.WriteLine("Printed the length, status {0}", getWebPage.IsCompleted);

            Console.ReadLine();


        }

        private static async Task<string> GetWebPage(Uri url)
        {
            Console.WriteLine("Before Waiting...");
            string data = await new WebClient().DownloadStringTaskAsync(url);
            Console.WriteLine("Waiting...");
            return data;
        }
    }
}
