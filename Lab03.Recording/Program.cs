using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Recording
{
    class Program
    {
        static void Main(string[] args)
        {
            Nagrywarka nagrywarka = new Nagrywarka();
            nagrywarka.Odtwarzaj();
            Console.WriteLine("Recorder status " + nagrywarka.getStan().ToString());
            nagrywarka.Nagrywaj();
            nagrywarka.Zatrzymaj();
            nagrywarka.Nagrywaj();
            Console.WriteLine("Recorder status " + nagrywarka.getStan().ToString());
            nagrywarka.Odtwarzaj();
            nagrywarka.Zatrzymaj();

            Console.Read();
        }
    }
}
