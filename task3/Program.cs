// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string InputInt(int num)
{
    if (num >= 1 && num <= 5)
    {
        return "Нет";
    }
    else
    {
        return "Да";
    }
}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7)
{
    num = num % 7;
    Console.WriteLine(InputInt(num));
}
else
{
    Console.WriteLine(InputInt(num));
}