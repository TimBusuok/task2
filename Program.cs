// Надайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum(int num, int num2)
{
    if(num == num2)
    {
        return num;
    }
    return (num + SumNum(num + 1,num2));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int m = EnterData("Введите число ");
int n = EnterData("Введите число ");
int sum = SumNum(m,n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");