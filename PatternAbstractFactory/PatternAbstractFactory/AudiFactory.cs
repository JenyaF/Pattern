using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    class AudiFactory : CarFactory
    {
        public AbstractCar CreateCar()
        {
            return new AudiCar();
        }
        public AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
    }

}
