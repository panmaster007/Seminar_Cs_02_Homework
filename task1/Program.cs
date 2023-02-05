System.Console.WriteLine("Введите число: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
	number = number / 10;
	number = number % 10;
	Console.WriteLine($"Вторая цифра введённого числа {number}");
}
else System.Console.WriteLine("Вы ввели не целое число или вовсе не число");