// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine ("Введите количество строк: ");
// int row = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(row,columns, -100, 100);
// PrintArray(array);

// void PrintArray(double[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = Convert.ToDouble(new Random().Next(minValue,maxValue+1))/10;
//         }
//     }
//     return result;
// }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

// Console.WriteLine ("Введите номер строки: ");
// int r = int.Parse(Console.ReadLine()!);
// Console.WriteLine ("Введите номер столбца: ");
// int c = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(5,5, 10, 100);
// PrintArray(array);

// if (r > array.GetLength(0) || c > array.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {r} строки и {c} столбца равно {array[r-1,c-1]}");
// }



// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write($"{Array[i,j]}| ");
//         }
//         Console.WriteLine();
//     }
// }



// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return result;
// }


// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine ("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row,columns, 0, 10);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / row;
    Console.Write(avarage + "; ");
}


void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}



int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}