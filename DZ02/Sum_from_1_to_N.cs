using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        int a = Int32.Parse(Console.ReadLine());
        long sum = 0;
        if(a>=0){
          for(long i=1; i<=a; i++){
            sum+=i;
          }
          Console.WriteLine("Сумма всех чисел до данного - " + sum);}
        else{
            Console.WriteLine("Введено отрицательное число");
        }
    }
}
