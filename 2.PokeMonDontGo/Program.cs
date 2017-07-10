using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PokeMonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            long removed = 0;

            while(input.Count!=0)
            {
                var inputIndex = int.Parse(Console.ReadLine());
                if (inputIndex < 0)
                {
                    var temp = input[0];
                    removed += temp;
                    input.RemoveAt(0);
                    input.Insert(0, input[input.Count - 1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if(input[i]<=temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                }
                else if(inputIndex>input.Count-1)
                    
                {
                    var temp = input[input.Count - 1];
                    removed += temp;
                    input.RemoveAt(input.Count - 1);
                    input.Add(input[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if(input[i]<=temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                }
                else
                {
                    var temp = input[inputIndex];
                    removed += temp;
                    input.RemoveAt(inputIndex);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if(input[i]<=temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                }
             
            }
            Console.WriteLine(removed);


        }
    }
}
