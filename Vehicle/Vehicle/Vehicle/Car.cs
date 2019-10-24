using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle 
    {
        public Car(int width, int length, int speed, int price, int year) : base(width, length, speed, price, year)
        {

        }

        public Car (int speed, int price, int year) : base (speed, price, year)
        {

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
