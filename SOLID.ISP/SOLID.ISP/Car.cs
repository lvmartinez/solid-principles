using System;

namespace SOLID.ISP
{
    public class Car: ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }
    }
}