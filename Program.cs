using System;

namespace Test_No._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array0 = { "" };
            string[] Array1 = { "" };
            string[] Array2 = { "" };
            string[] Array3 = { "" };
            string[] Array4 = { "" };

            while (true)
            {
                Console.WriteLine("Please input a Number from 0-3 to choose the following menu.");
                Console.WriteLine("[0] Show all recent files.");
                Console.WriteLine("[1] Open New files.");
                Console.WriteLine("[2] Open Recent files.");
                Console.WriteLine("[3] Exit.");

                Console.Write("Input Mode: ");
                int Mode = int.Parse(Console.ReadLine());
                
                while(Mode < 0 || Mode > 3)
                {
                    Console.WriteLine("Invalid Menu Number.");
                    Console.Write("Input Mode: ");
                    Mode = int.Parse(Console.ReadLine());
                }
                switch (Mode)
                {
                    case 0:
                        Console.WriteLine("[0] " + Array0[0]);
                        Console.WriteLine("[1] " + Array1[0]);
                        Console.WriteLine("[2] " + Array2[0]);
                        Console.WriteLine("[3] " + Array3[0]);
                        Console.WriteLine("[4] " + Array4[0]);
                        break;
                   
                    case 1:
                        Array0 = OpenNewFile(Array0);
                        break;

                    case 2:
                        Console.WriteLine(OpenRecentFile(Array4));
                        break;

                    case 3:
                        return;
                }
            }
        }


        static string[] OpenNewFile(string []Array0)
        {
            Console.Write("File Name: ");
            Array0[0] = Console.ReadLine();
            return Array0;
        }

        static string OpenRecentFile(string[] Array4)
        {
            if (Array4[0] == "")
            {
                return "No Recent File.";
            }
            else
            {
                return "No Recent File.";
            }
        }
    }
}
