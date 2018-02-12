using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem._1_Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();

            string pattern = @"\[[^\[\s]+<(\d+)REGEH(\d+)>[^\]\s]+]";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            int num = 0;
            
            foreach (Match match in matches)
            {
                int startNum = int.Parse(match.Groups[1].Value) + num;
                int endNum = int.Parse(match.Groups[2].Value) + startNum;

                num = endNum;

                numbers.Add(startNum);
                numbers.Add(endNum);
            }

            string result = string.Empty;

            foreach (var number in numbers)
            {
                if (number > input.Length)
                {
                    result += input[number % input.Length + 1];
                }
                else
                {
                    result += input[number];
                }
            }

            Console.WriteLine(result);
        }
    }
}
