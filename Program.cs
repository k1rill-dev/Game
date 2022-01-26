using Game;


Player player = new Player();
Enemy enemy = new Enemy();
Torgovets torgash = new Torgovets();


Console.WriteLine("Введи имя героя");

player.Name = Console.ReadLine();

Console.WriteLine(player.SayHello());

Console.WriteLine("Ты идешь по тропе и встретил монстра!");
while(enemy.Hp > 0 || player.Hp > 0)
{
    
    enemy.GetDamage(player.Strengh);
    player.GetDamage(enemy.Damage);
    Console.WriteLine($"Твоё хп - {player.Hp},  врага - {enemy.Hp}");
    if (enemy.Hp <= 0)
        break;
}
DeathHandler dh = player.Death;
DeathHandler dh1 = enemy.Death;
if (player.Hp <= 0)
{
    dh();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Game Over");
    Console.ResetColor();
}
else if (player.Hp > 0 && enemy.Hp <= 0)
{
    Console.WriteLine($"Кол-во hp - {player.Hp}");
    Console.WriteLine("Ты идешь по тропе и встретил торговца!");
    torgash.SayHi();
    string answer = Console.ReadLine();
    if (answer == "да")
    {
        TradingHandler th = torgash.Trading;
        th();
        player.Inventory.InsertRange(0, torgash.bought_items);
        foreach (var item in player.Inventory)
        {
            Console.WriteLine($"В вашем инвентаре: {item}");
        }
        player.Money = torgash.Player_money;
        Console.WriteLine(player.Money);
    }
    else
        Console.WriteLine("Ну ладно, аливедерчи");
}

Console.ReadKey();

delegate void DeathHandler();
delegate void TradingHandler();


