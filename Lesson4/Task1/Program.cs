// // Задайте одномерный массив, заполненный случайными числами. Определите количество простых чисел в этом массиве.

// // Примеры

// // [1 3 4 19 3] => 2
// // [4 3 4 1 9 5 21 13]  => 3

// using System.ComponentModel;
// using System.Globalization;

// int[] FillRandomArray(int size)
// {
//   int[] arr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 21);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   foreach(int el in arr)
//   {
//     Console.Write($"{el} ");
//   }
//   Console.WriteLine();
// }

// int CheckSumSimpleNum(int[] arr)
// {
//   int count = 0;
//   foreach(int el in arr)
//   {
//     if (CheckSimpleNum(el) == true)
//     {
//       count++;
//   //    Console.Write($"{el} " );
//     }
//   //  Console.WriteLine();
//   }
//   return count;
// }

// bool CheckSimpleNum(int el)
// {
//   bool simple;
//   if (el == 0 || el == 1)
//   return false;
//   else
//   for(int i = 2; i < el; i++)
//   {
//     if(el % i == 0)
//     return false;
//   }
//   return true;
// }

// Console.Write("Введите резмерность одномерного массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillRandomArray(length);
// PrintArray(arr);

// Console.WriteLine($"Количество простых чисел: {CheckSumSimpleNum(arr)}");


// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).

// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// Пример

// [1 5 11 21 81 4 0 91 2 3]

// => 2

// int[] FillRandomArray(int size)
// {
//   int[] arr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 1000);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   foreach (int el in arr)
//   {
//     Console.Write($"{el} ");
//   }
//   Console.WriteLine();
// }

// int IsInteresting(int[] arr)
// {
//   int count = 0;
//   foreach(int el in arr)
//   {
//     if (HaveOne(el) && MultySeven(el))
//     {
//       count++;
//     }
//   }
//   return count;
// }

// bool HaveOne(int num)
// {
//   if (num % 10 == 1)
//   {
//     return true;
//   }
//   return false;
// }

// bool MultySeven(int num)
// {
//   if (num % 7 == 0)
//   { return true;}
//   return false;
// }

// Console.Write("Введите резмерность одномерного массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillRandomArray(length);
// PrintArray(arr);
// Console.WriteLine($"Количество чисел удовлетворяющих условию: {IsInteresting(arr)}");
////////////////////////////////////////////////////////////
// Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 

// Сформируйте целое число, которое будет состоять из цифр из массива. Старший разряд числа находится на 0-м индексе, младший – на последнем. 

// Пример

// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// int[] FillRandomArray(int size)
// {
//   int[] arr = new int[size];
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = new Random().Next(0, 10);
//   }
//   return arr;
// }

// void PrintArray(int[] arr)
// {
//   foreach (int el in arr)
//   {
//     Console.Write($"{el} ");
//   }
//   Console.WriteLine();
// }

// double num(int[] col) // 1 4 8 7 8 7 4 9
// {
//     double n = 0;
//     foreach (var item in col)
//     {
//         n = n * 10 + item;
//     }
//     return n;
// }
// // 1
// // 1 *10 + 4 = 14
// // 14 * 10 + 8 = 148
// // 148 *10 + 7 = 1487...

// Console.Write("Введите резмерность одномерного массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillRandomArray(length);
// PrintArray(arr);
// Console.WriteLine(num(arr));
//////////////////////////////////////////////////////////////////////


