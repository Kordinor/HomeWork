using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите тип погоды (sunny or rainy)");
        string weather = Console.ReadLine();
        Console.WriteLine("Введите длину пути");
        int length = Int32.Parse(Console.ReadLine());
        if(length>0){
            switch(weather){
                case "sunny":
                    if(length<10){
    		            Console.WriteLine("Vehicle: none");}
    	
    	            else{
                		if(length<40){
                			Console.WriteLine("Vehicle: bike");}
                		
                		else{
                			if(length<400){
                				Console.WriteLine("Vehicle: car");}
                		
                			else{
                				if(length<900){
                					Console.WriteLine("Vehicle: train");}		
                				else{
                					Console.WriteLine("Vehicle: airplane");}
                			}			
                		}	
    	            }	
                	
                    break;
                case "rainy":
                    if(length<40){
    		            Console.WriteLine("Vehicle: car. Ride carefully");}
    	            else{
    		            Console.WriteLine("We don't recomend trip now");}
                    break;
                default:
                    Console.WriteLine("Неверное значение типа погоды");
                    break;
        }}    
        
        else{
            Console.WriteLine("Длина пути меньше или равна нулю");}
}}