using System;

class Program
{
    static void Main()
    { 
      Console.WriteLine("Введите год");
      int a = Int32.Parse(Console.ReadLine());
      if(a>-1){
          if(a % 4 == 0){
              Console.WriteLine(a + " год является высокосным");
          }
          else{
              Console.WriteLine(a + " год не является высокосным");
        }}
      else{
          Console.WriteLine("Невозможное значения для года");
      }    
    }
}