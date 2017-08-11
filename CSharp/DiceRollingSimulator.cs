//Started August 11th, 2017
//Created by SlimxShadyx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * List of things to do:
 *      
 */

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        
        static void Start()
        {
            Console.WriteLine("Welcome to the Dice Rolling Simulator! We are currently in Version 1.0");

            Console.WriteLine("");
            Console.WriteLine("");

            Dice_Chooser();
        }

        static void Exit()
        {
            Console.WriteLine("Thanks for using the Dice Rolling Simulator! Have a great day! <Press any key to exit>");

            Console.ReadKey();
        }

        static void Dice_Chooser()
        {
            Console.Write("Choose a dice! We currently have [6]: ");

            userInputDiceChooser:
            int dice_chooser = Convert.ToInt32(Console.ReadLine());

            Convert.ToInt32(dice_chooser);

            if (dice_chooser == 6)
            {
                Console.WriteLine("");
                Dice_6();
            }

            else
            {
                Console.WriteLine("");
                goto userInputDiceChooser;
            }
        }

        static void Dice_6()
        {
            Random dice_6_generator = new Random();

            int dice_6_rolled = dice_6_generator.Next(1, 7);

            Console.WriteLine("Rolling...");
            Console.WriteLine("");
            Console.WriteLine("The answer is.. " + dice_6_rolled + "!");
            Console.WriteLine("");

        userInputDice6:
            Console.Write("If you would like to roll again, type [roll]. If you would like to choose another die. type [dice]. If you would like to exit, type [exit]: ");
            string exit_or_start = Console.ReadLine();

            if (exit_or_start == "roll")
            {
                Console.WriteLine("");
                Dice_6();
            }
            
            else if (exit_or_start == "dice")
            {
                Console.WriteLine("");
                Dice_Chooser();
            }

            else if (exit_or_start == "exit")
            {
                Console.WriteLine("");
                Exit();
            }

            else
            {
                Console.WriteLine("");
                goto userInputDice6;
            }
        }
    }
}
