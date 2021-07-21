using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    public class Heroe
    {
        public string Name { get; set; }

        public int HP { get; set; }

        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string heroeName = parts[0];
                int hitPoints = int.Parse(parts[1]);
                int manaPoints = int.Parse(parts[2]);

                Heroe heroeHP = new Heroe
                {
                    Name = heroeName,
                    HP = hitPoints,
                };

                heroesHP.Add(heroeName, hitPoints);

                Heroe heroeMP = new Heroe
                {
                    Name = heroeName,
                    MP = manaPoints
                };

                heroesMP.Add(heroeName, manaPoints);
            }

            while (true)
            {
                string line = Console.ReadLine();
                
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" - ");
                string command = parts[0];
                string heroeName = parts[1];

                if (command == "CastSpell")
                {
                    int manaNedeed = int.Parse(parts[2]);
                    string spellName = parts[3];

                    if (heroesMP.ContainsKey(heroeName))
                    {
                        if (heroesMP[heroeName] >= manaNedeed)
                        {
                            heroesMP[heroeName] -= manaNedeed;
                            Console.WriteLine($"{heroeName} has successfully cast {spellName} and now has {heroesMP[heroeName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroeName} does not have enough MP to cast {spellName}!");
                        }
                    }
                }

                else if (command == "TakeDamage")
                {
                    
                    int damage = int.Parse(parts[2]);
                    string attacker = parts[3];

                    if (heroesHP.ContainsKey(heroeName))
                    {
                        heroesHP[heroeName] -= damage;

                        if (heroesHP[heroeName] > 0)
                        {
                            Console.WriteLine($"{heroeName} was hit for {damage} HP by {attacker} and now has {heroesHP[heroeName]} HP left!");
                        }
                        else
                        {
                            heroesHP.Remove(heroeName);
                            Console.WriteLine($"{heroeName} has been killed by {attacker}!");
                        }
                    }
                }

                else if (command == "Recharge")
                {
                    int manaAmount = int.Parse(parts[2]);

                    if (heroesMP.ContainsKey(heroeName))
                    {
                        heroesMP[heroeName] += manaAmount;

                        if (heroesMP[heroeName] <= 200)
                        {
                            Console.WriteLine($"{heroeName} recharged for {manaAmount} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroeName} recharged for {200 - (heroesMP[heroeName] - manaAmount)} MP!");
                            heroesMP[heroeName] = 200;
                        }
                    }
                }

                else if (command == "Heal")
                {
                    int healAmount = int.Parse(parts[2]);

                    if (heroesHP.ContainsKey(heroeName))
                    {
                        heroesHP[heroeName] += healAmount;

                        if (heroesHP[heroeName] <= 100)
                        {
                            Console.WriteLine($"{heroeName} healed for {healAmount} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroeName} healed for {100 - (heroesHP[heroeName] - healAmount)} HP!");
                            heroesHP[heroeName] = 100;
                        }
                    }
                }
            }

            Dictionary<string, int> sortedHPHeroes = heroesHP
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedHPHeroes)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine($"  HP: {kvp.Value}");

                foreach (var kvp2 in heroesMP)
                {
                    if (kvp2.Key == kvp.Key)
                    {
                        Console.WriteLine($"  MP: {kvp2.Value}");
                    }
                    
                }
            }
        }
    }
}
