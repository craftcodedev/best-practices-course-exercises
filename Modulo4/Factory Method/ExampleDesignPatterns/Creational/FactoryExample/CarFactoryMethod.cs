using Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class CarFactoryMethod
    {
        public Car BuyCar(string model)
        {
            Car car = CreateCar(model);
            car.BuyCar(model);
            return car;
        }


        public abstract Car CreateCar(string model);
    }
}
