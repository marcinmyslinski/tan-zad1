using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebCrawler
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int count = 0;
            //for (int i=0;i<10;i++)
            //{
            //    count+= i;
            //}
            //Console.WriteLine("Wynik "+ count);
            string websideUrl = "https://pja.edu.pl/";

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync(websideUrl);

            string content = await response.Content.ReadAsStringAsync();
            // próbowałem poniższymi stringami ale nie kompilowało poprawnie stringów w tablicy
          //  string[] first = { "@\"", "@\"\+\d\d", "@"\(\d\\d\)", "@"\(\+\d\d\)" };
           // string[] last = { "[-\\s\\.]?[0-9]{9}\"", "[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{3}\"", "[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{7}\"", "[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{3}\"" };
            
            //Console.WriteLine(content);

            // Adresy email / Numery telefonów
            //MatchCollection result = Regex.Matches(content, "[a-zA-Z]+[@][a-zA-Z.]+");
            // string expr = @"^[\+]?[(]?[\+]?[0-9]{2,3}[)]?[-\s\.]?[0-9]{2,3}?([-\s\.]?[0-9]{2,9})?([-\s\.]?[0-9]{2,9})?[-\s\.]?[0-9]{2,11}?$";
            //  MatchCollection result = Regex.Matches(content, @"[\+]?[(]?[\+]?[0-9]{2}[)]?[-\s\.]?[0-9]{2}?[-\s\.]?[0-9]{2}?[-\s\.]?[0-9]{2}?[-\s\.]?[0-9]{3}?");
            //   foreach (var r in result)
            //   {
            //       Console.WriteLine(r);
            //   }
          //  int i = 0;
          //  int j=0;
           // string pattern;
          //  for (i = 0; i < first.Length; i++)
           // { for(j = 0; j < last.Length; j++)
           //     {
                  //  pattern = first[i] + last[j];
                  //  MatchCollection result = Regex.Matches(content, @"\+\d\d[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{3}");
                    MatchCollection result = Regex.Matches(content, @"\+\d\d[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{3}");
                   // Console.WriteLine(pattern);
                    foreach (var r in result)
                    {
                        Console.WriteLine(r);
                    }
            MatchCollection result1 = Regex.Matches(content, @"\(\d\d\)[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{2}[-\s\.]?[0-9]{3}");
            // Console.WriteLine(pattern);
            foreach (var r in result1)
            {
                Console.WriteLine(r);
            }
            //MatchCollection result2 = Regex.Matches(content, @"[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{3}");
            //// Console.WriteLine(pattern);
            //foreach (var r in result2)
            //{
            //    Console.WriteLine(r);
            //}
            //    }


            //  }

        }
    }
}
