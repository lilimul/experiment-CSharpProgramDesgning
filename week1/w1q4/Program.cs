using System;
using System.Collections;
namespace w1q4
{
    class Program
    {

        static void stringTointArray(String input,out int[] array){
            String[] inputStringArray = input.Split(' ');
            int[] intArray= Array.ConvertAll<string,int>(inputStringArray,num => int.Parse(num));
            array=intArray;
            return;
        }
         private static bool IsToeplitzMatrix(int[,] matrix) {
        for(int i = 0; i < matrix.GetLength(0) - 1; i++) {
            for(int j = 0; j < matrix.GetLength(1) - 1; j++) {
                if(matrix[i + 1, j + 1] != matrix[i, j]) {
                    return false;
                }
            }
        }
        return true;
    }
        static void Main(string[] args)
        {
        Console.WriteLine("Tell me how many rows and columns this matrix have.");
        String inputLine = Console.ReadLine();
        int[] rowAndColumn={1,1};
        stringTointArray(inputLine,out rowAndColumn);
int[,] cost = null;
        cost = new int[,] {{ 1, 2, 3, 4 },
                           { 5, 1, 5, 3},
                           { 9, 5, 1, 2}
        };
        var res = IsToeplitzMatrix(cost);
        Console.WriteLine(res);
        Console.ReadKey();
        }
    }
}
