System.Console.WriteLine("Введите число обозначающее день недели:");

if(int.TryParse(Console.ReadLine(), out int a))
{
	switch (a)
	{	
		case 1:
			System.Console.WriteLine("Понедельник");
			System.Console.WriteLine("Это рабочий день!");
			break;
		case 2:
			System.Console.WriteLine("Вторник");
			System.Console.WriteLine("Это рабочий день!");
			break;
		case 3:
			System.Console.WriteLine("Среда");
			System.Console.WriteLine("Это рабочий день!");
			break;
		case 4:
			System.Console.WriteLine("Четверг");
			System.Console.WriteLine("Это рабочий день!");
			break;
		case 5:
			System.Console.WriteLine("Пятница");
			System.Console.WriteLine("Это рабочий день!");
			break;
		case 6:
			System.Console.WriteLine("Суббота");
			System.Console.WriteLine("Это выходной день!");
			break;
		case 7:
			System.Console.WriteLine("Воскресенье");
			System.Console.WriteLine("Это выходной день!");
			break;
		default:
			System.Console.WriteLine("Вы ввели неправильное число");
			break;
	}
}