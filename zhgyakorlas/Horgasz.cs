using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyakorlas
{
    public delegate void Mydelegate(IKifoghato kifoghato);
    class Horgasz
    {
        public event Mydelegate Kifogva;
        public event Mydelegate Eluszott;

        IKifoghato[] kifoghatok;

        private int szamlalo = 0;

        public Horgasz(int hossz)
        {
            kifoghatok = new IKifoghato[hossz];
        }

        public void Pecaz(IKifoghato kifoghato)
        {
            if (kifoghato.Kifog()==true)
            {
                kifoghatok[szamlalo] = kifoghato;
                szamlalo++;
                Kifogva?.Invoke(kifoghato);
            }
            if (szamlalo==kifoghatok.Length)
            {
                throw new Exception("Megtelt a zsák!");
            }
            else
            {
                Eluszott?.Invoke(kifoghato);
            }
        }
        private double OsszTomeg()
        {
            double szamlalo = 0;
            foreach (IKifoghato item in kifoghatok)
            {
                szamlalo += item.Tomeg;
            }
            return szamlalo;
        }
        private bool VanAranyhal()
        {
            bool seged = false;
            foreach (IKifoghato item in kifoghatok)
            {

                if (item is Gumicsizma)
                {
                    seged= true;
                }
                if (item is KisHal)
                {
                    if ((item as KisHal).aranyhale == true)
                    {
                        seged= true;
                    } 
                }
            }
            return seged;
        }
        public bool AsszonyHaragszik()
        {
            bool seged = false;
            if (szamlalo==0)
            {
                seged = true;
            }
            foreach (IKifoghato item in kifoghatok)
            {
                if (item is KisHal)
                {
                    if ((item as KisHal).aranyhale==true)
                    {
                        seged = false;
                    }
                }
                if (item is Gumicsizma)
                {
                    seged = true;
                }
            }
            if (OsszTomeg()<=10)
            {
                seged = true;
            }
            return seged;

        }
    }
}
