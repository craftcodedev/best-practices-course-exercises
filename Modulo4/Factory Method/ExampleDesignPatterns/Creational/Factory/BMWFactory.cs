using Factory.Models;
using Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BMWFactory : CarFactoryMethod
    {
        public override Car CreateCar(string model)
        {
            switch (model)
            {
                case "M3":
                    return new M3();
                case "M4":
                    return new M4();
                default:
                    break;
            }

            return null;
        }
    }
}
