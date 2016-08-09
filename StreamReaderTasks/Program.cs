using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader nope = new StreamReader("shakespeare.txt");
            using (nope)
            {
                int lineNumber = 0;

                string lineA = nope.ReadLine();

                while (lineA != null)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                    { Console.WriteLine(lineA); }
                    lineA = nope.ReadLine();

                }


                //line = reader.ReadToEnd();
                Console.WriteLine("Press the enter key to continue");
                Console.ReadKey();
                Console.Clear();

            }

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            StreamReader file = new StreamReader("shakespeare.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            string lineB;

            StreamReader reader = new StreamReader("shakespeare.txt");
            using (reader)
            {
                lineB = reader.ReadLine();

                while (lineB != null)
                {
                    string lowercase = lineB.ToLower();
                    string lowercaseKey = lowercase;
                    for (int i = 0; i < lowercase.Length; i++)
                    {
                        if (lowercaseKey == "b")
                        {
                            Console.Write(Char.ToUpper(lowercase[i]));
                        }

                        else
                        {
                            Console.Write(lowercase[i]);
                        }

                    }
                    Console.WriteLine();
                    lineB = reader.ReadLine();
                }

                Console.ReadLine();
            }
        }
    }
}
