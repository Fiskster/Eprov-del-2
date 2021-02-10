using System;

namespace Eprov_del_2
{
    public class ContrabandCar : Car
    {
        public ContrabandCar() //konstruktor som definerar variabler för objektet
        {   
            passengers = generator.Next(1,4);

            contrabandAmount = generator.Next(1,4);
        }
    }
}
