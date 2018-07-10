using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    class BMWFactory:CarFactory
    {
        public AbstractCar CreateCar()
        {
            return new BMWCar();
        }
        public AbstractEngine CreateEngine()
        {
            return new BMWEngine();
        }
    }
}
