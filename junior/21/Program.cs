//Программа проверяет пятизначное число на палиндромом.

long[] toArray(long num)
{
      int len = num.ToString().Length;
      long[] result = new long[len];
      while(num > 0)
      {
            len--;
            result[len] = num % 10;
            num = num / 10;
      }
      return result;
}

bool checkPoly(long[] ar)
{
      int i = 0;
      int count = (ar.Length + 1) / 2;
      while(count > 0)
      {
            if(ar[i] == ar[ar.Length-1-i])
            {
                  i++;
                  count--;
            }
            else return false;
      }
      return true;

}

string boolToStr(bool inp)
{
    if(inp) return "Да";
    else return "Нет";
}


System.Console.Write("Введите число: ");
long input = Convert.ToInt64(Console.ReadLine());


System.Console.WriteLine(boolToStr(checkPoly(toArray(input))));