using System.Globalization;
using System.Text;

namespace Task2024._09._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            #region Task2

            Console.OutputEncoding = Encoding.UTF8;

            int number = 98;

            if (number < 65 )
            {
                Console.WriteLine("Kəsildiniz");
            }
            else if (number >= 65 && number < 85)
            {
                Console.WriteLine("Adi diplom");
            }
            else if (number >= 85 && number < 95)
            {
                Console.WriteLine("Şərəf diplomu");
            }
            else
            {
                Console.WriteLine("Yüksək şərəf diplomu");
            }

            #endregion
        }
    }
}
