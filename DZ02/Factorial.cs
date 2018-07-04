using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("Введите число чей факториал вы хотите получить");
      int a = Int32.Parse(Console.ReadLine());
      long f = 1;
      for(long i=1; i<=a; i++){
          f*=i;
      }
      Console.WriteLine("Факториалом числа " + a + " является " + f);
    }
}