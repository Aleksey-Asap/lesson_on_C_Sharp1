// 13. Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    while (a > 999)
    {
        a = a / 10;
    }
    int remain = a % 10;
    Console.WriteLine(remain);
}

// Решение через строку:
// int num = 1234567;
// string str = num.ToString(); - строка функция ToString
// Console.WriteLine(str[2]);