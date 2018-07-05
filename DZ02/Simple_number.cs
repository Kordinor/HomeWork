using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        int a = Int32.Parse(Console.ReadLine());
        bool b = true;
        if(a>1){
            for(int i=2; i<a; i++){
                if(a%i==0){
                    b = false;
                    break;
                }
            }
            if(b){
                Console.WriteLine("Число " + a + " простое");
            }
            else{
                Console.WriteLine("Число " + a + " не является простым");
            }
        }
        else{
            Console.WriteLine("Число не соответсвует условию");
        }
    }
}