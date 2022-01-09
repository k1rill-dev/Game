
namespace Game
{
    internal class Torgovets : NPC
    {
        // класс торговца, где реализована(коряво, но реализована!) логика торговли
        public string Sword { get; set; } = "Меч-ваншот";
        public string Potion { get; set; } = "Зелье восстановления";
        public int Player_money { get; set; }
        
        private Player player = new Player();
        
        public List<string> bought_items = new List<string>();
        public Torgovets()
        {
            Name = "Васен";
            NPCMoney = 11111111;
            Hp = 100;
            Player_money = player.Money;
        }

        public override void SayHi()
        {
            base.SayHi();
            Console.WriteLine("Я - торговец, не хочешь ли поторгрвать со мной? (да/нет)");
        }

        public void Trading()
        {
            // тут не баг, а фича
            //money = player.Money;
            if (player != null)
            {
                if (Player_money < 1000)
                    Console.WriteLine("У тебя денег, будешь чем платить? Налом, безналом или?..");
                Console.WriteLine("У меня в наличии: а) Меч(100 монет)" +
                    "\n б)Зелье восстановления(10 монет)" +
                    "\n(а/б для покупки)");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "а":
                        //player.Money -= 100;
                        Player_money -= 100;
                        Console.WriteLine("Вы успешно купили товар!");
                        bought_items.Add(Sword);
                        break;
                    case "б":
                        //player.Money -= 10;
                        Player_money -= 10;
                        Console.WriteLine("Вы успешно купили товар!");
                        bought_items.Add(Potion);
                        break;
                    default:
                        Console.WriteLine("Говоришь, меч хочешь?)");
                            goto case "а";
                }
            }
            else
                Console.WriteLine("налл - аналл");
            
        }
    }
}
