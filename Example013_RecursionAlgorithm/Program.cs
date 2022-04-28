﻿
// string[,] table = new string[2, 5];
// // string.Empty
// // table[0,0]  table[0,1]  table[0,2]...table[0,4]
// // table[1,0]  table[1,1]  table[1,2]...table[1,4]
// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


int [,] matrix = new int [3, 4];

void PrintArray(int[ , ] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);