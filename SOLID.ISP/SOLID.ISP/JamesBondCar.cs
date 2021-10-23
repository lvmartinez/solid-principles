using System;

namespace SOLID.ISP
{
    public class JamesBondCar: ICar, IAirplane
    {
        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }
        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}