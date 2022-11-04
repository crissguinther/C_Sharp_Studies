using System;

namespace Program;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter matrix length(X, Y): ");
        string vals = Console.ReadLine() ?? "1 1";
        string[] valArr = vals.Split(" ");

        int[,] mat = new int [int.Parse(valArr[0]), int.Parse(valArr[1])];

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write("Enter value for X[" + i + "] and Y[" + j + "]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Check for ocurrences around: ");
        int num = int.Parse(Console.ReadLine());

        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] == num)
                {
                    Console.WriteLine($"\nPosition {i},{j}");
                    if (j > 0) Console.WriteLine("Left: " + mat[i, j - 1]);
                    if (j < (mat.GetLength(1) - 1)) Console.WriteLine("Right: " + mat[i, j + 1]);
                    if (i < (mat.GetLength(0) - 1)) Console.WriteLine("Down: " + mat[i + 1, j]);
                    if (i > 0) Console.WriteLine("Up: " + mat[i - 1, j]);
                }
            }
        }
    }
}