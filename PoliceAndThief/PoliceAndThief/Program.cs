using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceAndThief;

internal class Program
{
    static void Main(string[] args)
    {
        Grid grid = new Grid(100, 25);

        int y = 100;
        int x = 25;
        int[,] town = { };

        town = Grid.CreateGrid(x, y, town);

        Grid.Print(x, y,town);

    }
}

