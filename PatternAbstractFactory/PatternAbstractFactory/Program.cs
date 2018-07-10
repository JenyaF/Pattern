using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Абстрактная фабрика № 1 
            CarFactory bmw_car = new BMWFactory();
            Client c1 = new Client(bmw_car);
            c1.Run();
            // Абстрактная фабрика № 2      
            CarFactory audi_factory = new AudiFactory();
            Client c2 = new Client(audi_factory);
            c2.Run();
            Console.Read();
        }
    }
}
