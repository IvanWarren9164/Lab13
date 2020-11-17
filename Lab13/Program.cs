using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rockpaperscissor = new Random();
            Console.WriteLine("Enter your name: \n");
            string userName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Which player would you like to play against? \n" +
                "1. Easy Player \n" +
                "2. Hard Player \n");
            int userPlayerChoice = int.Parse(Console.ReadLine());

            switch (userPlayerChoice)
            {
                case 1:
                    returnRoshamboChoice();
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    returnRoshamboChoice();
                    int randomChoice = rockpaperscissor.Next(0, 3);
                    Console.WriteLine("case 2");
                    break;
                default:
                    break;
            }


        }
        public static string returnRoshamboChoice()
        {
            Console.WriteLine("Enter your selection by choosing the number: \n" +
                 "1. Rock \n" +
                 "2. Paper \n" +
                 "3. Scissors \n");
            int playerchoice = int.Parse(Console.ReadLine());
            switch(Roshambo)
            {
                case Roshambo.Rock:
                    return "rock";
                case Roshambo.Scissors:
                    return "scissor";
                case Roshambo.Paper:
                    return "paper";
                default:
                    Console.WriteLine("Default choice \n");
                    break;
            }

        }
        public abstract class Player
        {
            public string userChoice { get; set; }
            public string RoshamboValue { get; set; }

            public abstract Roshambo GenerateRoshambo();

            Random rockpaperscissor = new Random();

        }
        /*public class rockPlayer: Player
        {

        }*/

        public class randomPlayer: Player
        {
            
        }

        public class PlayerThree : Player
        {
            public override Roshambo GenerateRoshambo()
            {
                throw new NotImplementedException();

                
            }
        }

        public class RoshamboApp
        {

        }
    }
    public enum Roshambo
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
}
