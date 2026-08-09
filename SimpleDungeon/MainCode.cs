using TextAnimate;
namespace SimpleDungeon
{
    internal class MainCode
    {
        static void Main(string[] args)
        {
            Anim.Type("-----Главное меню-----", 1250);
            Console.WriteLine();
            Anim.Delay("1 - начать", 1250);
            Anim.Delay("2 - выход", 1250);
            Console.Write("Ввод:");
            string input = Console.ReadLine();
            Console.WriteLine(); // Пустая строка для отступа

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("  ┌──────────┐      ┌──────────┐  ");
                    Console.WriteLine("  │    1     │      │     2    │  ");
                    Console.WriteLine("  │          │      │          │  ");
                    Console.WriteLine("  │  [ ]     │      │     [ ]  │  ");  //двери
                    Console.WriteLine("  │          │      │          │  ");
                    Console.WriteLine("  │          │      │          │  ");
                    Console.WriteLine("  |          |      |          |  ");
                    Console.WriteLine("──┴──────────┴──────┴──────────┴──");

                    // Задерживаем экран, чтобы рассмотреть двери
                    Anim.Type("\nНажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    break;

                case "2":
                    Environment.Exit(0); //выход
                    break;

                default:
                    //если неправильный ввод
                    Console.WriteLine("Ошибка: нужно ввести только цифру 1 или 2!");

                    Console.WriteLine("\nНажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}