using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliceAndThief
{
	public class Grid
	{
		public int X { get; set; }
        public int Y { get; set; }
		public int[,] town { get; set; }

        public Grid(int x, int y)
		{
            X = x;
            Y = y;
		}

        public static int[,] CreateGrid(int SizeX, int SizeY, int[,] Matris)
        {
            int sizeX = SizeX;
            int sizeY = SizeY;
            Matris = new int[sizeX, sizeY];

            return Matris;
        }

        public static void Print(int x, int y, int[,] town)
        {
            

            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    if (town[row, col] == 0)
                    {
                        Console.Write("X");
                    }

                }
                Console.WriteLine();
            }

        }
	}
}

