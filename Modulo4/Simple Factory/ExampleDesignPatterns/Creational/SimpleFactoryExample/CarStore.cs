using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class CarStore
    {
        private SimpleCarFactory factory;

        public CarStore(SimpleCarFactory factory)
        {
            this.factory = factory;
        }

        public void BuyCar(string brand)
        {
            var car = factory.CreateCar(brand);
            car.BuyCar(brand);
        }
    }
}
