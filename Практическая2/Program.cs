using System.Security.Principal;

namespace Практическая2
{

    public class Number
    {
        private int number;

        public Number(int num)
        {
            number = num;
        }

        /// <summary>
        /// Перегрузка оператора true
        /// </summary>
        /// <param name="en"></param>
        /// <returns></returns>
        public static bool operator true(Number en)
        {
            return en.number % 2 == 0;
        }

       /// <summary>
       /// Перегрузка оператора false
       /// </summary>
       /// <param name="en"></param>
       /// <returns></returns>
        public static bool operator false(Number en)
        {
            return en.number % 2 != 0;
        }
    }

    internal class Program
    {

        static void Main()
        {
            try
            {
                Random random = new Random();
                int numbers = random.Next();
                //  Console.WriteLine();
                Number number = new Number(numbers);
                //   EvenNumber even2 = new EvenNumber(7);

                if (number)
                {


                    Console.WriteLine($"Число {numbers}- четное");
                }
                else
                {
                    Console.WriteLine($"Число {numbers} нечетное");
                }

                Console.WriteLine($"Начать заново Y да N - нет");

                var Символ = Convert.ToChar(Console.ReadLine());

                switch (Символ)
                {
                    case 'Y':
                        Console.Clear();
                        Main();
                        break;

                    case 'N':
                        Console.WriteLine($"Досвидания !");

                        Environment.Exit(0);

                        break;

                }
                Console.ReadLine();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
                Main();

            }
        }
    }
}