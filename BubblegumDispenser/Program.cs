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
                    Console.Write("1) Get bubblegum machine \n2) Take bubblegum from machine \n3) Exit \ninput: ");
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
                            Console.WriteLine("Gum machine has arrived");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("You already have a gum machine with gum left in it \nPlease empty your current machine before getting a new one.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        if (gumMachine.Container.IsFull == true)
                        {
                            TakeGum(gumMachine, true, false);
                        }
                        else
                        {
                            Console.WriteLine("Either your gum machine is empty or you don't have one yet. \nPlease try again.");
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
            bool handleTurn = false;
            bool isFull = true;
            GumMachine gumMachine = new GumMachine(isFull, handleTurn);
            return gumMachine;
        }

        public static void TakeGum(GumMachine gumMachine, bool handleTurn, bool isFull)
        {
            int input;
            do
            {
                do
                {




                    Console.WriteLine("1) Back to menu \n2) Take gum (" + gumMachine.Container.Bubblegum.Count + " Bubblegum left)");
                    if (!int.TryParse(Console.ReadLine(), out input))
                    {
                        Console.WriteLine("Invalid input, try again");
                    }
                    Console.Clear();
                } while (input > 2);

                if (input == 2)
                {

                    handleTurn = true;
                    Console.WriteLine("You got: " + gumMachine.Dispencer.DispenseGum().Type);
                    handleTurn = false;

                    if (gumMachine.Container.Bubblegum.Count == 0)
                    {
                        Console.Clear();
                        Console.Write("Gum machine is empty \nget a new one");
                        isFull = false;
                        Console.ReadKey();
                    }
                    Thread.Sleep(1000);
                }
                Console.Clear();
            } while (input != 1);
        }
    }
}
