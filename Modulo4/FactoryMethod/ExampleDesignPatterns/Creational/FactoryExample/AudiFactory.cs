using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Models;
using Factory.SimpleFactory;

namespace Factory
{
    public class AudiFactory : CarFactoryMethod
    {
        public override Car CreateCar(string model)
        {
            switch (model)
            {
                case "A3":
                    return new A3();
                case "A4":
                    return new A4();
                default:
                    break;
            }

            return null;
        }
    }
}
