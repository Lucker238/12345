//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
string findDay(int x)
{
    if(x == 7) return "Воскресенье";
    else if(x == 6) return "Суббота";
    else if(x == 5) return "Пятница";
    else if(x == 4) return "Четверг";
    else if(x == 3) return "Среда";
    else if(x == 2) return "Вторник";
    else if(x == 1) return "Понедельник";
    else return "Я не знаю такого дня недели";
}
Console.WriteLine(findDay(a));