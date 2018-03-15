using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Don`t say, that i`m eblying");
	        Console.WriteLine("Eldyesh eshe i kak");
	        Console.WriteLine("Zaodno i proverim kak ty git osvoil");
            Console.WriteLine("Ta norm osvoil)))");

        jopa:
            Console.WriteLine("Privet, you are in jopa!");

            goto jopa;*/

            //Моё дз по тому, что я говорил:

            #region Number one

            int a = 10;
            int b = 5;
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            #endregion

            #region Number two

            //Опять рисование херни

            #endregion

            #region Number three

            //Опять рисование херни

            #endregion

            #region Number four

            int shit = 5;
            int small_shit = 4;
            do
            {
                shit *= small_shit--;
            } while (small_shit != 0);

            Console.WriteLine(shit);

            #endregion

            //Потратил 10 минут...
        }
    }
}
