using System;

namespace Eprov_del_2
{
    public class CleanCar : Car
    {
        public CleanCar() //konstruktor som definerar variabler för objektet
        {
            passengers = generator.Next(1,3);

            contrabandAmount = 0;

            
        }
    }
}
