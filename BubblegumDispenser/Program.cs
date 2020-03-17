using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BubblegumDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            GumMachine gumMachine = new GumMachine(false, false);
            while (true)
            {
                
                int input; 
                do
                {
                    Console.WriteLine("Bubblegum Machine");
                    Console.Write("1) Get bubblegum machine \n2) Take bubblegum from machine \n3) Exit \nInput: ");
                    if (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Invalid input, try again. \nPress any key to continue...");
                        Console.ReadKey();
                    }

                    Console.Clear();

                } while (input < 1 || input > 3);


                switch (input)
                {
                    case 1:
                        if (gumMachine.Container.IsFull == false)
                        {
                            Console.Write("Getting gum machine"); Thread.Sleep(800); Console.Write("."); Thread.Sleep(800); Console.Write("."); Thread.Sleep(800); Console.Write("."); Thread.Sleep(800);
                            gumMachine = GetGumMachine();
                            Console.Clear();
                            Console.WriteLine("Gum machine has arrived.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You already have a gum machine with gum left in it. \nPlease empty your current machine before getting a new one. \nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        if (gumMachine.Container.IsFull == true)
                        {
                            TakeGum(gumMachine);
                        }
                        else
                        {
                            Console.WriteLine("Either your gum machine is empty or you don't have one yet. \nPlease try again. \nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static GumMachine GetGumMachine()
        {
            GumMachine gumMachine = new GumMachine(true, false);
            return gumMachine;
        }

        public static void TakeGum(GumMachine gumMachine)
        {
            int input;
            do
            {
                do
                {
                    Console.Write("1) Take gum (" + gumMachine.Container.Bubblegum.Count + " Bubblegum left ("
                        + gumMachine.Container.CountByType("Blueberry") + " Blueberry) ("
                        + gumMachine.Container.CountByType("Blackberry") + " Blackberry) ("
                        + gumMachine.Container.CountByType("Tutti-Frutti") + " Tutti-Frutti) ("
                        + gumMachine.Container.CountByType("Orange") + " Orange) ("
                        + gumMachine.Container.CountByType("Strawberry") + " Strawberry) ("
                        + gumMachine.Container.CountByType("Apple") + " Apple)) " +
                        "\n2) Back to menu \nInput: ");

                    if (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                    Console.Clear();

                    if (gumMachine.Container.Bubblegum.Count == 0 && input == 1)
                    {
                        Console.WriteLine("Current gum machine is empty. \nGet a new one in the menu \nPress any key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }

                } while (input > 2);

                if (input == 1)
                {
                    gumMachine.Handle.Turn = true;
                    Console.Write("You got: ");
                    string type = gumMachine.Dispencer.DispenseGum().Type;
                    identifyType(type);
                    Console.Write(type);
                    Console.ResetColor();
                    gumMachine.Handle.Turn = false;
                    Thread.Sleep(1000);

                    if (gumMachine.Container.Bubblegum.Count == 0)
                    {
                        Console.Write("\n\nThat was the last bubblegum. \nPress any key to continue...");
                        gumMachine.Container.IsFull = false;
                        Console.ReadKey();
                    }
                }
                Console.Clear();
            } while (input != 2);
            
        }

        public static void identifyType(string type)
        {
            if (type == "Blueberry")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (type == "Blackberry")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            if (type == "Tutti-Frutti")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (type == "Orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            if (type == "Strawberry")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (type == "Apple")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
}
