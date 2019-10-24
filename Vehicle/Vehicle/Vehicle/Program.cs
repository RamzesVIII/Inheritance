using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(900, 1000000, 2016)
            {
                Passengers = 80,
                Hight = 3000
            };
            plane.ShowInfo();
        }
    }
}
