using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Character
    {
        public string name { get; }
        public string image { get; }
        public int level { get; set; }
        public int exp { get; set; }
        
        public Character(string name, string image)
        {
            this.name = name;
            this.image = image;
            level = 1;
            exp = 0;
        }

        public void gainEXP(int exp)
        {
            this.exp += exp;
        }

        public void LevelUp()
        {
            this.level += level;
        }


        public override string ToString() 
        {
            return $"Имя: {name} " +
                $"Опыт: {level} " +
                $"Уровень: {exp} " +
                $"Image: {image} ";

        }
    }
}
