// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5

// Console.WriteLine("Введите трёхзначное число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int sDigit = firstNumber / 10;
// int secondDigit = sDigit % 10;
// Console.WriteLine("Вторая цифра числа: " + secondDigit);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number > 999)
// {
//     number = number / 10;
// }
// int res = number % 10;
// if (number > 99 && number < 1000)
// {
//     Console.WriteLine("Третья цифра числа: " + res);
// }
// else if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// - решение строкой

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 100)
// {
//     string str = number.ToString();
//     Console.WriteLine("Третья цифра числа: " + str[2]);
// }
// else
// Console.WriteLine("Третьей цифры нет");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите день недели от 1 до 7: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 6)
// {
//     Console.WriteLine("нет");
// }
// else Console.WriteLine("да");