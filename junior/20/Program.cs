//Задать номер четверти, показать диапазоны для возможных координат

string findSqr(int n)
{
    if(n == 1) return "X > 0; Y > 0";
    else if(n == 2) return "X < 0; Y > 0";
    else if(n == 3) return "X < 0; Y < 0";
    else if(n == 4) return "X > 0; Y < 0";
    else return "Нету такого номера плоскости";
}

Console.Write("Введите номер плоскости: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(findSqr(N));