// По двум заданным числам проверять является ли одно квадратом другого

bool isSquare(int a, int b)
{
    return a == b * b || b == a * a;
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(isSquare(number1, number2));