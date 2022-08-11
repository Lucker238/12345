//Даны два числа. Показать большее и меньшее число
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
string findBigger(int x, int y)
{
    if(x > y) return $"{x} больше чем {y}";
    else return $"{y} больше чем {x}";
}
Console.WriteLine(findBigger(a, b));