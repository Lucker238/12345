//Дано число. Проверить кратно ли оно 7 и 23
bool isDevide(int i)
{
    if(i % 7 == 0 && i % 23 == 0) return true;
    else return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(isDevide(num));