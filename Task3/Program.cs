Console.Write("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
int num2 = num / 100;
Console.WriteLine($"Сумма чисел {num1} и {num2} равна: {num1 + num2}");