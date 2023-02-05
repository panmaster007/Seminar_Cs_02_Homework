System.Console.Write("Введите число: ");

if(int.TryParse(Console.ReadLine(), out int number))
{
   if (number > 99)
	{
		while (number > 999)
		{
			number = number / 10;
		}
		number = number % 10;
		System.Console.WriteLine($"Третяя цифра введённого числа {number}");
   }
   else System.Console.WriteLine("Введенное число является менее чем трехзначным и третьей цифры у него нет");
}
else System.Console.WriteLine("Вы ввели не целое число или вовсе не число");