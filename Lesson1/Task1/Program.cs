//using System;
// Напишите программу, которая на вход принимает 
// два целых числа и проверяет, является ли первое число квадратом второго.
Console.Write("Введите целое число №1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == Math.Pow(num2, 2))
{
  Console.WriteLine($"Условия выполнены! Квадрат числа {num2} является числом {num1}");
}
else
{
  Console.WriteLine($"Условия выполнены! Квадрат числа {num2} не является числом {num1}");
}