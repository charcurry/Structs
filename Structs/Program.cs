using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        struct Vector3
        {
            public float x, y, z;
        }

        struct Point2D
        {
            public int x, y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Structs");
            Console.WriteLine();

            Vector3 position;
            position.x = 0.0f;
            position.y = 0.0f;
            position.z = 0.0f;


            //player
            int score = 0;
            int health = 100;
            int shield = 100;
            //int playerX = 10;
            //int playerY = 10;
            Point2D playerPosition;
            playerPosition.x = 10;
            playerPosition.y = 10;

            //enemies
            int numEnemies = 1000;
            //int enemyX = 10;
            //int enemyY = 10;
            Point2D[] enemyPosition = new Point2D[numEnemies];
            // loop to initialize them...
            for (int i = 0; i < numEnemies; i++)
            {
                enemyPosition[i].x = 10;
                enemyPosition[i].y = 10;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit... ");
            Console.ReadKey(true);

        }
    }
}
