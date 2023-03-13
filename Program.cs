using System;
using System.IO;

namespace midTermExam2{
    class Program{
        static void Main(string[] arg){
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            bool canOrder = true;
            string breakfast = "Breakfast Set";
            string weekend = "Weekend Set";
            string coffee = "Coffee";
            
            int[] workDay = {1,2,3,4,5};
            int[] weekDay = {6,7};

            bool isWorkDay = workDay.Contains(day);
            bool isWeekDay = weekDay.Contains(day);

            int breakfastTimeOver = 11;

            int breakfastCount = 5;
            int weekendCount = 2;
            int coffeeCount = 3;



            while(canOrder){
                string order = Console.ReadLine();

                switch(order){
                    case ("Breakfast Set"):
                        breakfastCount--;
                        if(breakfastCount < 0 ){
                                 Console.WriteLine("Sorry your order is out of stock");
                        }else if (time > breakfastTimeOver)
                        {
                        Console.WriteLine("Sorry your order is not available");
                        } break;
                    case ("Weekend Set"):
                        weekendCount--;
                        if(weekendCount < 0 ){
                                 Console.WriteLine("Sorry your order is out of stock");
                        }else if (isWorkDay)
                        {
                        Console.WriteLine("Sorry your order is not available");
                        } break;
                    case ("Coffee"):
                        coffeeCount--;
                        if(coffeeCount < 0 ){
                                 Console.WriteLine("Sorry your order is out of stock");
                        }
                         break;
                    case ("End"):
                        canOrder = false;
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                    }
            }
            
        }
    }
}
