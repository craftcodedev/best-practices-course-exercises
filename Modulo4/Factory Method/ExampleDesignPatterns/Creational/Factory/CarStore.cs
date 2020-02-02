using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CarStore
    {
        private SimpleCarFactory carFactory;

        public CarStore(SimpleCarFactory carFactory)
        {
            this.carFactory = carFactory;
        }

        public void BuyCar(string model, string brand)
        {
            var car = carFactory.CreateCar(model);
            car.BuyCar(brand);
        }
    }
}
