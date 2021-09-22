using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VariablesHud1._0
{
    class Program
    {
        
        static void Main(string[] args)
        
        {
            int score;
            score = 0;
            int multiply;
            multiply = 2;
            int health;
            health = 100;
            int enemyPoints;
            enemyPoints = 400;
            float lives;
            lives = 3;
            string deathMsg;
            deathMsg = "YOU DIED";
            string H;
            H = "Health ";
            String L;
            L = " Lives ";
            string HS;
            HS = " High Score ";

            
            



            
            Console.WriteLine("Synth Fighters - Asthectic Protectors");
            Console.ReadKey(true);

            Console.WriteLine("Player Start");
            Console.ReadKey(true);

            Console.WriteLine(H + health + L + lives + HS + score);
            Console.ReadKey(true);

            Console.WriteLine("Player Attacks Enemy.....");
            Console.ReadKey(true);

            Console.WriteLine("MASSIVE DAMAGE");
            Console.ReadKey(true);

            Console.WriteLine("Player Gains 400 points!");
            Console.ReadKey(true);
            score = enemyPoints;
            if (score <= 0)
            {
                score = score + enemyPoints;
            }
            Console.WriteLine(H + health + L + lives + HS + score );

            Console.WriteLine("Player Picks Up Multiplyer 2X");
            if (enemyPoints <= 400)
            {
                score = enemyPoints * multiply;

            }

            Console.WriteLine(HS + score);
            Console.ReadKey(true);
            
            
            Console.WriteLine("Player Takes Down 2 More Enemies! ");
            Console.ReadKey(true);

            Console.WriteLine(HS + (score + enemyPoints) * multiply);
            Console.ReadKey(true);

            score = ((score + enemyPoints) * multiply);

            Console.WriteLine(H +health + L + lives + HS + score);
            Console.ReadKey(true);

            Console.WriteLine("Player Encounters High Level Enemy");
            Console.ReadKey(true);

            Console.WriteLine("Player is about to take 100 damage");
            Console.ReadKey(true);
            health = health - 100;
            if (health <= 0)
            {
                lives = lives - 1;
                Console.WriteLine(deathMsg);
            }

            Console.WriteLine("player has " + lives + " lives left");
            Console.ReadKey(true);
            
            

            
           
            
                
             
            














        }
    } 

}
