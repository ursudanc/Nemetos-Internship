using System;
using System.Collections.Generic;

namespace PaperPlanes
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter player 1 name:");
            var player1 = new Player(Console.ReadLine());

            Console.WriteLine("Enter player 2 name:");
            var player2 = new Player(Console.ReadLine());

            var game = new Game(player1, player2);
            player1.Board = new Board(8, 8);
            player2.Board = new Board(8, 8);
            Actions actiuni = new Actions();
            Console.Clear();
            actiuni.selectPlanePos(player1);
            actiuni.selectPlanePos(player2);


            var currentPlayer = player1;
            var otherPlayer = player2;
            while (!game.IsOver())
            {
                
                actiuni.attackingPart(currentPlayer);

                var isHit = otherPlayer.Board.DrawPlaneHit(actiuni.xx,actiuni.yy);

                Console.WriteLine(isHit ? "Target hit!" : "Missed...");

                currentPlayer = currentPlayer.Name == player1.Name ? player2 : player1;

                otherPlayer = otherPlayer.Name == player1.Name ? player2 : player1;

                Console.WriteLine("Press any key for next player...");

                Console.ReadKey();

                Console.Clear();
            }

            actiuni.gameOver(otherPlayer);
        }
    }

}
