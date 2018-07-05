using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        int a = Int32.Parse(Console.ReadLine());
        if(a>0){
            for(int i=1; i*i<=a; i++){
                Console.Write(i*i + " ");
            }
        }
        else{
            Console.WriteLine("Число не является натуральным");
        }
    }
}