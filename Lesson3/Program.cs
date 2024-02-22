// 

// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
//Замените отрицательные элементы на положительные, а положительные на отрицательные.

// Пример

// [1 -5 6]

// => [-1 5 -6]

// void RandomFillArray(int[] arr)
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     Random rnd = new Random();
//     arr[i] = rnd.Next(-10, 10);
//   }
// }

// void PrintArrayToScreen(int[] arr)
// {
//   foreach(var e in arr)
//   { Console.Write($"{e} "); }
//   Console.WriteLine();
// }

// int[] array = new int[10];
// RandomFillArray(array);

// PrintArrayToScreen(array);

// for(int i = 0; i < array.Length; i++)
// {
//   array[i] *= -1;
// }

// PrintArrayToScreen(array);

// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.

// Пример

// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

void RandomFillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Random rnd = new Random();
    arr[i] = rnd.Next(-10, 10);
  }
}

void PrintArrayToScreen(int[] arr)
{
  foreach(var e in arr)
  { Console.Write($"{e} "); }
  Console.WriteLine();
}

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[n];
// RandomFillArray(mas);
// PrintArrayToScreen(mas);
// int[] mas2 = new int[n / 2];

// for (int i = 0; i < mas2.Length; i++)
// {
//   mas2[i] = mas[i] * mas[mas.Length - 1 - i]; 
// }

// PrintArrayToScreen(mas2);

int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int[] mas = new int[3];
for (int i = 0; i < mas.Length; i++)
{
  mas[i] = n % 10;
  n /= 10;
}
PrintArrayToScreen(mas);