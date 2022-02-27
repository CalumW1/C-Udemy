using System;
using System.IO;

namespace ReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading from a text file;
            /*string text = System.IO.File.ReadAllText(@"C:\Users\Calum.Wilson\OneDrive - Independent Solutions\Desktop\ReadAndWrite\Test.txt");

            Console.WriteLine("Text file contains the following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Calum.Wilson\OneDrive - Independent Solutions\Desktop\ReadAndWrite\Test.txt");

            foreach(string line in lines)
            {
                Console.WriteLine("\t " + line);
            }

            Console.ReadKey();*/



            // write to a new file; 
            string[] lines = { "first line", "second line", "third line", "2312", "232", "1234" };

            /*File.WriteAllLines(@"C:\\Users\\Calum.Wilson\\OneDrive - Independent Solutions\\Desktop\\ReadAndWrite\\test2.txt", lines);

            // test upload

            // ask for a file name;
            Console.WriteLine("Filename: ");
            string filenameInput = Console.ReadLine();

            Console.WriteLine("Text in file: ");
            string input = Console.ReadLine();

            // Write user input to a text file. 
            File.WriteAllText(@"C:\\Users\\Calum.Wilson\\OneDrive - Independent Solutions\\Desktop\\ReadAndWrite\\" + filenameInput + ".txt", input);*/

            // using StremWriter
            using(StreamWriter file = new StreamWriter(@"C:\\Users\\Calum.Wilson\\OneDrive - Independent Solutions\\Desktop\\ReadAndWrite\\streamWriter.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\\Users\\Calum.Wilson\\OneDrive - Independent Solutions\\Desktop\\ReadAndWrite\\streamWriter2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // writing to existing file
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\Calum.Wilson\\OneDrive - Independent Solutions\\Desktop\\ReadAndWrite\\streamWriter2.txt", true))
            {
                file.WriteLine("new line");
            }
        }
    }
}
