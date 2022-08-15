// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

string findSqr(int x, int y)
{
    if(x > 0 && y > 0) return "Точка находится в первой плоскости";
    else if(x < 0 && y > 0) return "Точка находится во второй плоскости";
    else if(x <0 && y < 0) return "Точка находится в третьей плоскости";
    else return "Точка находится в четвертой плоскости";
}

Console.Write("Введите X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSqr(X, Y));