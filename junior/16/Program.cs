// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
string isHolliday(int number)
{
    if(number % 6 == 0 || number % 7 == 0) return "Да!";
    else return "Нет!";

}

Console.Write("Введите число дня недели(от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(isHolliday(number));