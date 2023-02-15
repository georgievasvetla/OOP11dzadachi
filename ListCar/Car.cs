using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCar
{
    internal class Car:IComparable<Car>,IPrint
    {
        private string marka;
        private string regN;
        private double price;
        public string Marka
        {
            get { return marka; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Grephka");
                marka = value;
            }
   
        }
        public string RegN
        {
            get { return regN; }
            set
            {
                if (value.Length < 5)
                    throw new ArgumentException("opitaj pak");
                regN = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if(value<0)
                    throw new ArgumentException("Grewka");
                price = value;
            }

        }
        public Car(string marka,string regN,double price)
        {
            this.marka = marka;
            this.regN = regN;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine($"marka={this.marka}"  +
                $"regN={this.regN}  price={this.price}");
        }

        public int CompareTo(Car order)
        {
            return marka.CompareTo(order.marka);
        }
    }
}
