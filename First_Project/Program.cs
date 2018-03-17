using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string search;

            for(;;)
            {
                Console.Write("Enter the way to file: "); //@"D:\Repositories\test.txt"
                search = Console.ReadLine();
                try
                {
                    FileStream file = new FileStream(@search, FileMode.Open);
                    StreamReader reader = new StreamReader(file);
                    Console.WriteLine();
                    Console.WriteLine(reader.ReadToEnd());
                    Console.WriteLine();
                    reader.Close();
                    break;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Error. File not found.");
                    Console.WriteLine();
                    continue;
                }
                catch (ArgumentException)
                {
                    continue;
                }
            }          
        }
    }
}
