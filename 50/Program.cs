/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Введите число строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента: ");
int i0 = Convert.ToInt32(Console.ReadLine());
int j0 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++){
        array[i, j] = rnd.Next(-10, 10);
        
        Console.Write(array[i, j]+ " ");      
    }
    Console.WriteLine();
}

if (i0 >= m || j0 >= n || i0 < 0 || j0 < 0) {
    Console.WriteLine("Такого элемента нет");
}
else {
    Console.WriteLine("Значение элемента {0}", array[i0,j0]);
}