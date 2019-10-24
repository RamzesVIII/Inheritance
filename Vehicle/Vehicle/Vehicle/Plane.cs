using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Plane : Vehicle
    {
        public Plane (int width, int length, int speed, int price, int year)
            :base (width, length, speed, price, year)
        {

        }
        public Plane (int speed, int price, int year) : base (speed, price, year)
        {

        }

        private int hight;
        public int Hight
        { get { return hight; }
            set { hight = value; } }

        private int passengers;
        public int Passengers
        { get { return passengers; }
          set { passengers = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Passengers = {0} \n Hight = {1}", passengers,hight);
        }

    }
}
