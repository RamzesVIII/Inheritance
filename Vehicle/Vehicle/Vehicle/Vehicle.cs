using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        readonly int width;
        public int Width
        { get { return width; } }

        readonly int length;
        public int Length
        { get { return length; } }

        readonly int price;
        public int Price
        { get { return price; } }

        readonly int speed;
        public int Speed
        { get { return speed; } }

        readonly int year;
        public int Year
        { get { return year; } }

        public Vehicle(int width, int length, int speed, int price, int year)
        {
            this.width = width;
            this.length = length;
            this.speed = speed;
            this.price = price;
            this.year = year;

        }

        public Vehicle(int speed, int price, int year) : this(0, 0, speed, price, year)
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine(" Speed = {0} \n Price = {1} \n Year = {2}", speed, price, year);
        }
    }
}
