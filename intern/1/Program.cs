 //По двум заданным числам проверять является ли первое квадратом второго
 Console.Write("Введите первое число: ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
 int b = Convert.ToInt32(Console.ReadLine());
 string isSquare(int x, int y)
 {
    if(Math.Pow(Convert.ToDouble(y), 2) == Convert.ToDouble(x)) return $"{x} является квадратом {y}";
    else return $"{x} не является квадратом {y}";
 }
 Console.WriteLine(isSquare(a, b));