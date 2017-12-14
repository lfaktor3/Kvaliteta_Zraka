using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_CRUD Polutanti = new Class_CRUD();
            List<Pollutants> lPollutants = Polutanti.GetAllPollutants();
            for (int i = 0; i < lPollutants.Count; i++)
            {
                Console.WriteLine(lPollutants[i].POLLUTANT_NAME + "\n");
                Console.WriteLine("-----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
