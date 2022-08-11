 //Вывести квадрат числа
Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
double findSquare(double x)
{
    return Math.Pow(x, 2);
}
Console.WriteLine(findSquare(a));
