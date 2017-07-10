using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.PokemonEvolution
{
    class PokemonEvo
    {
        public string EvoType { get; set; }
        public int EvoIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var PokeDex = new Dictionary<string,List<PokemonEvo>>();
            var input = Console.ReadLine();
            while (true)
            {
                var tokens = Regex.Split(input, @"->").Select(p => p.Trim()).ToArray();
                if(tokens[0]== "wubbalubbadubdub")
                {
                    break;
                }
                if (tokens.Length > 1)
                {
                    string pokemon = tokens[0];
                    string evo = tokens[1];
                    int evoIndex = int.Parse(tokens[2]);

                    if (!PokeDex.ContainsKey(pokemon))
                    {
                        PokeDex.Add(pokemon, new List<PokemonEvo>());
                    }
                    PokeDex[pokemon].Add(new PokemonEvo()
                    {
                        EvoType = evo,
                        EvoIndex = evoIndex
                    });
                }
                else
                {
                    if(PokeDex.ContainsKey(tokens[0]))
                    {
                        Console.WriteLine($"# {tokens[0]}");
                        foreach (var evo in PokeDex[tokens[0]])
                        {
                            Console.WriteLine($"{evo.EvoType} <-> {evo.EvoIndex}");
                        }
                    }
                }
                input = Console.ReadLine();
                
            }
            foreach (var pokemon in PokeDex)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evo in pokemon.Value.OrderByDescending(p=>p.EvoIndex))
                {
                    Console.WriteLine($"{evo.EvoType} <-> {evo.EvoIndex}");

                }
            }
            
        }
    }
}
