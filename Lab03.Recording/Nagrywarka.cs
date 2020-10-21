using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03.Recording.enums;

namespace Lab03.Recording
{
    class Nagrywarka
    {
        private MiejsceNagrywania miejsceNagrywania;
        private Stan stan;

        public Stan getStan() { return stan; }
        public MiejsceNagrywania getMiejsceNagrywania() { return miejsceNagrywania; }
        public void setMiejsceNagrywania(MiejsceNagrywania _miejsceNagrywania) { miejsceNagrywania = _miejsceNagrywania; }

        public Nagrywarka()
        {
            Wlacz();
        }

        private void Wlacz() { 
            if(stan != Stan.WYLACZONA)
            {
                stan = Stan.WLACZONA;
                Console.WriteLine("Condition: Run");
            }

            else Console.WriteLine("Recorder is already running!");
        }
        public void Wylacz() { stan = Stan.WYLACZONA; }
        public void Odtwarzaj() {
            if (stan == Stan.NAGRYWANIE)
                Console.WriteLine("You can't open while recording!");
            else if (stan != Stan.WYLACZONA)
            {
                stan = Stan.ODTWARZANIE;
                Console.WriteLine("Condition: Opening!");
            }
            else Console.WriteLine("Recorder is OFF!");
        }
        public void Nagrywaj()
        {
            if (stan == Stan.ODTWARZANIE)
                Console.WriteLine("You can't record while is open!");
            else if (stan == Stan.WYLACZONA)
                Console.WriteLine("Recorder is OFF!");
            else
            {
                stan = Stan.NAGRYWANIE;
                Console.WriteLine("Condition: Recording");
            }
        }
        public void Zatrzymaj() 
        { 
            stan = Stan.ZATRZYMANA;
            Console.WriteLine("Condition: Stop");
        }
    }
}
