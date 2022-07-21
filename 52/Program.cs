/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите число строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        array[i, j] = rnd.Next(-10, 10);
        
        Console.Write(array[i, j]+ "  ");      
    }
    Console.WriteLine("");
}

for (int j = 0; j < n; j++) {
    double sum = 0;
    for (int i = 0; i < m; i++) {
        sum += array[i, j];
    }
    Console.WriteLine("ср.арифметическое по столбцам {0}", sum / m);
}
