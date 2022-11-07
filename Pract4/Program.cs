namespace Pract4
{
    internal class Program
    {

        static void Main()
        {
            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.Write("-> ");

            while (true)
            {
               
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("-> ");

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Console.SetCursorPosition(0, position);
                    Console.Write("-> ");
                }
                if (position == 0)
                {
                    position = 1;
                    Console.Clear();
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("-> ");
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 1)
                    {

                    }
                }
            }
        }

        static void zametka()
        {
      
        }




    }
}