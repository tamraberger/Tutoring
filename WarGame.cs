using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarClasses
{
    public class War

    {
        public int ComputerScore { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerNewTotal = 26;
        public int ComputerNewTotal = 26;
       

       
        
        public void NewGame()
        
        {
            var deck = new Deck();
            
            do
            {
                Console.Clear();
                var playerCard = deck.Drawcard("player");
                var computerCard = deck.Drawcard("computer");

                Console.WriteLine("Your card is the {0}",
                     playerCard.FullName());
                Console.WriteLine("The computer drew the {0}",
                    computerCard.FullName());


            if (playerCard.Value > computerCard.Value)
            {
                Console.WriteLine("\nPlayer, you won this round!");
                PlayerNewTotal = PlayerNewTotal + 1;
                ComputerNewTotal = ComputerNewTotal - 1;
                Console.WriteLine("\nNew scores:\nPlayer has {0} cards\nComputer has {1} cards", PlayerNewTotal, ComputerNewTotal);
              
            }
            else if (playerCard.Value < computerCard.Value)
            {
                Console.WriteLine("\nComputer wins this time.");
                ComputerNewTotal = ComputerNewTotal + 1;
                 PlayerNewTotal = PlayerNewTotal - 1;
                 Console.WriteLine("\nNew scores:\nPlayer has {0} cards\nComputer has {1} cards", PlayerNewTotal, ComputerNewTotal);
                 //Console.ReadLine();
                
                }
            else Console.WriteLine("This round was a tie! " +
                "Try again!");
                Console.ReadLine();
           

            }
            while (ComputerNewTotal < 51 || PlayerNewTotal < 51);

            if (ComputerNewTotal == 51)
            {
                Console.WriteLine("GAME OVER! The computer won this Game of War! Try again!");
            }
            else
                Console.WriteLine("Congratulations, you won the Game of War!!");
        }

      public void Welcome()
        {
            Console.WriteLine("Hello! This is the card game, war. " +
            "You will be drawing your card at the same time as the computer. " +
            "The player who draws the higher card, wins. Press enter to play, " +
            "and use enter to continue taking turns.");
            Console.ReadLine();
        }



        }

    }


