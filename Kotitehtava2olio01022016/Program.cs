using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava2olio01022016
{
    class Program
    {
        static void Main(string[] args)
        {
            int totta = 1;

            while (totta == 1)
            {
                System.IO.StreamWriter outputFile = null;
                Console.Write("Give a number (enter or not a number ends): ");
                string line = Console.ReadLine();

                try
                {
                    int number = int.Parse(line);
                    outputFile = new System.IO.StreamWriter("T2Integers.txt");
                    outputFile.WriteLine(number);
                }
                catch (FormatException)
                {
                }
                try
                {
                    double number = double.Parse(line);
                    outputFile = new System.IO.StreamWriter("T2Doubles.txt");
                    outputFile.WriteLine(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You didn't give a number!");
                    totta = 0;
                }
                finally
                {
                    // check for null because OpenWrite might have failed
                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }

                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                try
                {
                    string text = System.IO.File.ReadAllText(mydocpath + "/T2Integers.txt");
                    System.Console.WriteLine("Contents of T2Integers.txt:\n" + text);
                    string text2 = System.IO.File.ReadAllText(mydocpath + "/T2Doubles.txt");
                    System.Console.WriteLine("Contents of T2Doubles.txt:\n" + text);
                }
                finally
                { }

                Console.ReadLine();
            }
        }
    }
}
