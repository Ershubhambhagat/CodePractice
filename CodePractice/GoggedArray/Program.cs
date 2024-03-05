using System.Diagnostics.CodeAnalysis;

class Program
{
     static void Main(string[] args)
    {
        int[][] triangle = new int[][]
        {
            //Declear and initialize a jagged array
            new int []{1},
            new int []{2,3},
            new int []{4,5,6},
            new int []{7,8,9},

        };
        //use for 'for each 'loop  to print each row of the trangle 
        foreach (int[] triangle1 in triangle)
        {
            foreach (var item in triangle1)
            {
                Console.WriteLine(item);
            }
        }

        //2d 

        int[,] grid = new int[,]
       {
            //Declear and initialize a 2D array

            {1,2 },
            {3,4},
            {5,6},
            {6,7},
            {7,8}, 
            {8,9},
            {9,10},

       };
        //use Nested ForEach Loop to print each number of grid

        for (int i = 0; i <grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1);  j++)
            {
                Console.WriteLine(  grid[i,j]);
            }

        }
    }
}