using System;

namespace zhgyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Gumicsizma gumicsizma = new Gumicsizma();
            NagyHal nagyHal = new NagyHal(10);
            KisHal kisHal = new KisHal(1, false, true);
            KisHal kisHal2 = new KisHal(2, true);
            KisHal kisHal3 = new KisHal(4, false);



            Horgasz Jani = new Horgasz(3);
            Jani.Eluszott += KiirKudarc;
            Jani.Kifogva += KiirSiker;

            try
            {
                Jani.Pecaz(kisHal3);
                Jani.Pecaz(kisHal2);
                Jani.Pecaz(kisHal);
                Jani.Pecaz(nagyHal);
                Jani.Pecaz(gumicsizma);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine(Jani.AsszonyHaragszik());



        }

        private static void KiirSiker(IKifoghato kifoghato)
        {
            Console.WriteLine("Jani fogott egy halat"+" tömege: "+kifoghato.Tomeg);
        }

        private static void KiirKudarc(IKifoghato kifoghato)
        {
            Console.WriteLine("Jani nem fogott egy halat" + " tömege: " + kifoghato.Tomeg);
        }
    }
}
