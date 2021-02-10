using System.CodeDom.Compiler;
using System;

namespace Eprov_del_2
{
    public class Car
    {
        public int passengers;
        public int contrabandAmount;


        public bool alreadyChecked;

        public Random generator;

        public bool Examine()
        {
             alreadyChecked = true; 
             
             Random generator2 = new Random(); //Gör så att om du har mer contraband i bilen är det en större chans att bli tagen
            if  (generator2.Next(0,contrabandAmount) >= 2)
            {
                return true;
            }
            else //Return false om man inte hittar contraband
            {
                return false;
            }

        }
    
    }
}
