using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperPlanes
{
    class Actions
    {
        public int xx, yy;
 
        public void selectPlanePos(Player player)
        {
            bool exceptie= false ;
            var xPlayer = 0;
            var yPlayer = 0;
            do
            {
                try
                {
                    exceptie = false;
                    Console.WriteLine($"{player.Name} select plane position (x,y):");
                    var positionPlayer = Console.ReadLine();
                    var positionsPlayer = positionPlayer.Split(",");
                   xPlayer = int.Parse(positionsPlayer[0]);
                    yPlayer = int.Parse(positionsPlayer[1]);
                    if (xPlayer <= 5 && yPlayer < 5)
                    {

                        player.DrawPlane(yPlayer, xPlayer);
                        player.DrawBoard();
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                        
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Please insert only numeric values");
                    Console.WriteLine("Press any key to continue...");
                    exceptie = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (IndexOutOfRangeException)
                {
                    exceptie = true;
                    Console.WriteLine("Please add values for X axis <=5 and for Y axis <5");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (exceptie == true);
        }

        public void attackingPart(Player player)
        {
            
            Console.WriteLine($"{player.Name} press any key to start game...");
            Console.ReadKey();

            player.DrawBoard();
            player.rounds++;
            bool exceptie = false;
            do {
                try
                {
                    exceptie = false;
                    Console.WriteLine("Number of rounds:" + $"{player.rounds}");
                    Console.WriteLine($"{player.Name} select square to hit (x,y):");
                    var position = Console.ReadLine();
                    var positions = position.Split(",");
                    var x = int.Parse(positions[0]);
                    var y = int.Parse(positions[1]);
                    if ((x < 0 || x > 7) && (y < 0 || y > 7))
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        xx = x;
                        yy = y;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please insert only numeric values");
                    Console.WriteLine("Press any key to continue...");
                    exceptie = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                catch(IndexOutOfRangeException)
                {
                    exceptie = true;
                    Console.WriteLine("Please add values for X axis and Y axis between 0-7");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            }while (exceptie == true) ;
        }
        
        public  void gameOver(Player player)
        {
            Console.WriteLine($"Game Over! {player.Name} has won!");
            Console.WriteLine("------------------------");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
