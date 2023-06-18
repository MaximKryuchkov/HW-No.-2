// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = ReadInt("Введите трёхзначное число: ");
int sum = num.ToString().Length;

if (sum < 3 || sum > 3)
{
    System.Console.WriteLine("Ошибка !");
}
else
{
    System.Console.WriteLine(InCenter(num));;
}
int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
