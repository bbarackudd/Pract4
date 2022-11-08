namespace Pract4
{
    internal class Program
    {

        static void Main()
        {
            bool stop = false;
            int pos = 1;
            int maxpos = 0;
            DateTime data = DateTime.Today;
            List<Zametka> zametki = new List<Zametka>()
            {
                new Zametka() {nazvanie="Пойти поесть", text = "Мы должны быть полны сил для работы", data = new DateTime(2022,11,08)},
                new Zametka() {nazvanie="Написать фит с моргенштерном", text = "Надо поднять денег чтобы купить шаурму", data = new DateTime(2022,11,09)},
                new Zametka() {nazvanie="Бэмс Бэмс кукуруза вжих вжих", text = "Делаем пупкорн скупаем акции", data = new DateTime(2022,11,10)},
                new Zametka() {nazvanie="Едем за шаурмой", text = "Скидка на шаурму на курском вокзале", data = new DateTime(2022,11,11)},
                new Zametka() {nazvanie="Поздороваться со Стасевичем", text = "Поприветствовать старого пусть порадуется", data = new DateTime(2022,11,12)}
            };
            List<Zametka> todayTasks = new List<Zametka>();
            while (!stop)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(data.ToShortDateString());
                Console.SetCursorPosition(0, pos);
                Console.Write("→");

                foreach (Zametka zametka in zametki)
                {
                    if (zametka.data == data)
                    {
                        Console.WriteLine("  " + zametka.nazvanie);
                        maxpos += 1;
                        todayTasks.Add(zametka);
                    }
                }
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        pos++;
                        break;
                    case ConsoleKey.UpArrow:
                        pos--;
                        break;
                    case ConsoleKey.RightArrow:
                        data = data.AddDays(1);
                        break;
                    case ConsoleKey.LeftArrow:
                        data = data.AddDays(-1);
                        break;
                    case ConsoleKey.Escape:
                        stop = true;
                        Console.WriteLine("Уже уходишь?");
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Zametka zametka = todayTasks[0];
                        Console.WriteLine(zametka.nazvanie);
                        Console.WriteLine(zametka.text);
                        Console.WriteLine("Нажмите кнопку для продолжения");
                        Console.ReadLine();
                        break;
                }
                if (pos == 0)
                {
                    pos = 1;
                }
                if (pos > maxpos)
                {
                    pos = maxpos;
                }
            }
        }
    }
}