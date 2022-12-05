// //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.Write("Введите числа : ");
// int[] numbers = GetArrayFromString(Console.ReadLine());
// Console.WriteLine($"Колличество чисел больше 0 -> {GetCountPositiveElements(numbers)}");

// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(numS[i]);
//     }
//     return result;
// }

// int GetCountPositiveElements(int[] array)
// {
//     int count = 0;
//     foreach (int item in array)
//     {
//         if (item > 0) count++;
//     }
//     return count;
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значения b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);

Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    return result;
}
