using Factory.Models;
using Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class SimpleCarFactory
    {
        public Car CreateCar(string brand)
        {
            Car car = null;

            switch (brand)
            {
                case "Audi":
                    car = new Audi();
                    break;
                case "BMW":
                    car = new BMW();
                    break;
                default:
                    break;
            }

            return car;
        }
    }
}
