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
        /*
         * *******TODO**********
         * 
         * 0.Different logic at different functions(very different at another files)
         * 1.In my opinion you should to remove readers to some clas (for example Parser). But now it's ok. Let it be
         * 
         * See below
         */
        static void Main(string[] args)
        {
            string search;

            for(;;)//Msut be inside try statement (standards for writing code =) )
            {
                Console.Write("Enter the way to file: "); //@"D:\Repositories\test.txt"
                search = Console.ReadLine();
                try
                {
                    //FIX THIS

                    FileStream file = new FileStream(@search, FileMode.Open);//this part is superfluous. This class basically for work with bytes

                                                                 //Further (if you take my opinion into account) it will better to use Stream(it's abstract class) 
                    StreamReader reader = new StreamReader(file);//Because from stram you can get any other stream

                    /* ^
                     * |
                     * |
                     * StreamReader reader = new StreamReader(@search); //It's enough
                     */



                    //.......................................................................................................



                    Console.WriteLine();
                    Console.WriteLine(reader.ReadToEnd());//Console.WriteLine('\n' + reader.ReadToEnd() + '\n'); Will be better =)
                    Console.WriteLine();

                    reader.Close();//Very old solution. Now you must use 'using' statement. This statement automaticly closes streams, connections etc. 
                                   //(Works only for classes that implement interface IDisposable)

                    /*    Example
                     * using(reader) ----> OR -----> using (StreamReader reader = new StreamReader(file)) with row removal above
                     * {
                     *      //Inner code
                     *      Console.WriteLine();
                     *      Console.WriteLine(reader.ReadToEnd());
                     *      Console.WriteLine();
                     * }
                     */

                    break;//I think this is superfluous :)


                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Error. File not found.");
                    Console.WriteLine();//Plase use \n. Looks so bad
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
