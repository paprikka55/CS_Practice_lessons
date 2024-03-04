// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

// string CharsToString(char[] arr)
// {
//   string str = "";
//   foreach (char item in arr)
//   {
//     str += item;
//   }
//   return str;
// }


// char[] chars = new char[] {'a', 'b', 'c', 'd', 'e'};
// Console.WriteLine(CharsToString(chars));

// На основе символов строки (тип string) сформировать массив символов 
// (тип char[]). Вывести массив на экран.

// using System.Text;
// char[] StringToCharArray(string inputString)
// {
//   char[] charArray = new char[inputString.Length];
//   for (int i = 0; i < inputString.Length; i++)
//   {
//     charArray[i] = inputString[i];
//   }
//   return charArray;
// }

// void PrintCharArray(char[] arr)
// {
//   foreach (char item in arr)
//   {
//     Console.Write($"'{item}' ");
//   }
// }

// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;
// Console.Write("Введите строку: ");
// string inputString = Console.ReadLine()!;
// PrintCharArray(StringToCharArray(inputString));

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// Выяснить, сколько среди введённых букв гласных (aouei).

using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введите строку: ");
string str1 = Console.ReadLine()!;
string str2 = "aoueiAOUEIАОУЕЁИЫЮЯаоуиыёеюя";
int count = 0;
foreach (char item in str1)
{
  if (str2.Contains(item))
  {
    Console.Write($"{item} ");
    count++;
  }
}
Console.WriteLine();
Console.WriteLine($"Количество гласных: {count}");
