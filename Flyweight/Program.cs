using Flyweight;

Character Knight = new("Louis", "Louis.jpg");
Character Troll = new("Sponky", "Sponky.png");

Knight.LevelUp();
Troll.LevelUp();

Knight.gainEXP(100);
Troll.gainEXP(140);

Troll.LevelUp();

Console.WriteLine(Troll.ToString() + '\n' + Knight.ToString());

