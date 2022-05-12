// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int n = number.Length;
if (n > 2)
    Console.WriteLine("Третья цифра числа " + number + " --> " + number[2]);
else
    Console.WriteLine("Третьей цифры нет");




