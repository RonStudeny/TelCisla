using System;
using System.Text.RegularExpressions;

namespace TelCisla
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "+420 000 111 222 (420) 000 111 222 111 000 222 000111222 +420000111222 000111 +(420) 000 111 222";

            Regex regex = new Regex(@"(?<natNum>(\+420( )?)|(\(420\) ))?(?<phNum>(([0-9]( )?){3}){3})");

            MatchCollection mc = regex.Matches(input);

            foreach (Match m in mc)
            {
                Console.WriteLine(m + $" National number: {m.Groups["natNum"]}, Phone number: {m.Groups["phNum"]}");
            }
        }
    }
}
