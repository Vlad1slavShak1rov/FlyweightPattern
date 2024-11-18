using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Flyweight
{
    public class Factory
    {
       Dictionary<string, Character> dict = new Dictionary<string, Character>();

        public Character CharacterFactory(string name, string image)
        {
            string key = $"{name}_{image}";
            if (!dict.ContainsKey(key))
            {
                Character character = new Character(name, image);
                dict.Add(key, character);
                Console.WriteLine($"Создан новый персонаж: {name}");
            }
            else Console.WriteLine("Данный персонаж уже существует!");

            return dict[key];
        }
    }
}
