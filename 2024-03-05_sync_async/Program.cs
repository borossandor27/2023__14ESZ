using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using _2024_03_05_sync_async;

namespace _2024_03_05_sync_async
{
    class Program
    {
        static string endPointUrl = "https://retoolapi.dev/KqpqJ9/data";
        /*
         * {
         * "id": 1,
         * "name": "Hershel Shields",
         * "salary": 30903
         * },
         */
        static List<Adat> adatok = new List<Adat>();

        static void Main(string[] args)
        {
            restapiAdatok().Wait();
            foreach (Adat item in adatok)
            {
              //  Console.WriteLine($"{item.Id}. {item.Name}");
            }
            legjobbanKereso();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void legjobbanKereso()
        {
            long maxSalary = adatok.Max(a => a.Salary);
            Adat legmagasabb = adatok.Find(a => a.Salary == maxSalary);
            Console.WriteLine("1. feladat");
            Console.WriteLine($"\tA legjobban kereső dolgozó: {legmagasabb.Name}");
        }

        static async Task restapiAdatok()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, endPointUrl);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();
            adatok = Adat.FromJson(jsonString).ToList();
        }
    }
}
