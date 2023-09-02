namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 - +");
                Console.WriteLine("2 - -");
                Console.WriteLine("3 - *");
                Console.WriteLine("4 - /");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число 1:");
                double number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число 2:");
                double number2 = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.WriteLine(number + number2);
                    break;
                    case 2:
                        Console.WriteLine(number - number2);
                        break;
                    case 3:
                        Console.WriteLine(number * number2);
                        break;
                    case 4:
                        Console.WriteLine(number / number2);
                        break;
                    default:
                        Console.WriteLine("asd");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }



        }
    }
}