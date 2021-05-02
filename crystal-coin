namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinCount;
            int crystalCount;
            int crystalPrice = 5;
            string name;
            bool enoughCoin;

            Console.WriteLine("Добро пожаловать в лавку чудес,путник! Скажи,как я могу к тебе обращаться?");
            name = Console.ReadLine();
            Console.WriteLine($"Хорошо,{name},вижу,что ты пришёл за магическими кристалами. Тебе повезло,сегодня кристалы по {crystalPrice} монет за штуку.");
            Console.WriteLine($"Мхм...скажи {name},а какой суммой монет ты располагаешь?");
            coinCount = Convert.ToInt32(Console.ReadLine());
            crystalCount = coinCount / crystalPrice;
            Console.WriteLine($"{name} на {coinCount} монет ты можешь купить {crystalCount} кристалов. Сколько кристалов ты желаешь приобрести?");
            crystalCount = Convert.ToInt32(Console.ReadLine());
            enoughCoin = coinCount >= crystalCount * crystalPrice;
            crystalCount *= Convert.ToInt32(enoughCoin);
            coinCount -= crystalCount * crystalPrice;
            Console.WriteLine($"Замечательно,{name},держи свои {crystalCount} кристалов и сдачу в {coinCount} монет.");
            Console.WriteLine($"Теперь у вас {crystalCount} кристалов.");
            Console.WriteLine($"У вас осталось {coinCount} монет.");

            
            

           
        }
    }
}
