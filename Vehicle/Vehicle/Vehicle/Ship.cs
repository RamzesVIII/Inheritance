using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Ship : Vehicle
    {
        public Ship(int width, int length, int speed, int price, int year)
            : base(width, length, speed, price, year)
        {

        }
        public Ship(int speed, int price, int year) : base(speed, price, year)
        {

        }

        private string port;
        public string Port
        { get; set; }

        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Passengers = {0} \n Port - {1}", passengers, port);
        }
    }
}
