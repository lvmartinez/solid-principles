using System;

namespace SOLID.ISP
{
    public class Airplane: IAirplane
    {
        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}