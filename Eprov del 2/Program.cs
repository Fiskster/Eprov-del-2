using System;
using System.Collections.Generic;


namespace Eprov_del_2
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Car> cars = new List<Car>();
         
          Console.WriteLine("Hur många bilar vill du ha?");
          string userinput = Console.ReadLine();
          int carAmt;

           int.TryParse(userinput, out carAmt);
           if (carAmt > 0)
           {
             bool success = true; 
           }
           else {
             Console.WriteLine("skriv nummer över 0 klant..");
           }

          if (success)
          { 
              
           for (int i = 0; i < carAmt; i++) //Räknar hur många bilar användaren ville ha och slumpar därefter
           {
               Random carGen = new Random();
               if(carGen.Next(0,10) >= 5)
               {
                   cars.Add(new CleanCar());
               }
               else 
               {
                 cars.Add(new ContrabandCar());
               }
           }
          
          
          
          }


        }
    }
}
