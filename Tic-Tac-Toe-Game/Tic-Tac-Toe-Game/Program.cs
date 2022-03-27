using System;

namespace Tic_Tac_Toe_Game
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            // TODO: Setup your game.
            // Create a new method that creates your players and instantiates the game class.
            // Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player.
            // If it's a draw, tell them that there is no winner. 

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Player player = game.Play();

            if (player.Name == "Player 1")
            {
                Console.WriteLine("Player 1 is win");
            }else if (player.Name == "Player 2")
            {
                Console.WriteLine("Player 2 is win");
            }
            else if (player.Name == "Draw")
            {
                Console.WriteLine("Draw");
            }

        }
    }
}
