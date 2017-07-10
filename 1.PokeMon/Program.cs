using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePowerN = long.Parse(Console.ReadLine());
            long originalN = pokePowerN;
            long pokeDistanceM = long.Parse(Console.ReadLine());
            long exhaustionFactorY = long.Parse(Console.ReadLine());
            int targets = 0;


            while(pokePowerN>=pokeDistanceM)
            {
                pokePowerN -= pokeDistanceM;
                targets++;
                
                if(pokePowerN==(0.50*originalN))
                {
                    try
                    {
                        pokePowerN = pokePowerN / exhaustionFactorY;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(targets);
        }

  
         
        
    }
}
