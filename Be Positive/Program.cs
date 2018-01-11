using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                List<int> numbers = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                List<int> answer = new List<int>();

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        answer.Add(currentNum);
                    }
                    else
                    {
                        if (j == numbers.Count - 1)
                        {
                            break;
                        }
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            answer.Add(currentNum);
                        }
                        j++;
                    }
                }

                if (answer.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", answer));
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
