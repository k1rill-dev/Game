using Game;


Player player = new Player();
Enemy Enemy = new Enemy();

Console.WriteLine("Введи имя черт");

player.Name = Console.ReadLine();

Console.WriteLine(player.SayHello());

DeathHandler dh = player.Death;
player.Hp = 0;


if (player.Hp == 0)
{
    dh();
}


delegate void DeathHandler();


