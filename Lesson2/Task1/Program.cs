// Напишите программу, которая принимает на вход  трёхзначное число и удаляет вторую цифру этого число

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int s = num/100*10 + num%10;
// Console.WriteLine(s);

// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.

// int num = new Random().Next(100, 5000);
// Console.WriteLine(num);

// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 1000 && num >= 100)
// {
//   int num_3 = num % 10;
//   int num_2 = num / 10 % 10;

//   Console.WriteLine($"{Math.Pow(num_2, num_3)}");
// }
// else
// Console.WriteLine($"Число {num} не трехзначное!");

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num1 % num2 != 0)
// {
//   Console.WriteLine($"Число {num2} не является кратным {num1}! Остаток от деления: {num1 % num2}");
// }
// else
// {
//   Console.WriteLine($"Число {num2} является кратным {num1}!");
// }

// Напишите программу, которая выводит третью слева 
// цифру заданного числа или сообщает, что третьей цифры нет.
 Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num_cur = 0;
// if (num < 0)
// num = - num;
// if (num < 100)
// Console.WriteLine("Третьей цифры нет!");
// else
// {
//   while (num > 100)
//   {
//     num_cur = num%10;
//     num /= 10;
//   }
//   Console.WriteLine(num_cur);
// }
string num = Console.ReadLine();
if (num.Length < 3)
Console.WriteLine("Третьей цифры нет!");
else
{
  Console.WriteLine(num[2]);
}
