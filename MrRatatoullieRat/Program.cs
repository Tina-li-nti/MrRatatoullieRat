using System;
using System.Text.Json;

namespace MrRatatoullieRat
{
    class Program
    {
        static void Main(string[] args)
        {
            ratClass rat = new ratClass()
            {

            };
            Console.WriteLine("Please assign Remmy the rat his skills");
            Console.WriteLine("Available ponits: 250");
            Console.WriteLine("soupMaker: ");
            string soupMakerS;
            soupMakerS = Console.ReadLine();
            int soupResultat;
            bool goodSoup = int.TryParse(soupMakerS, out soupResultat);
            rat.soupMaker = soupResultat;
            Console.WriteLine("beefSteaker: ");
            string beefSteakerS;
            beefSteakerS = Console.ReadLine();
            int beefResultat;
            bool goodBeef = int.TryParse(beefSteakerS, out beefResultat);
            rat.beefSteaker = beefResultat;
            Console.WriteLine("pastaBaker: ");
            string pastaBakerS;
            pastaBakerS = Console.ReadLine();
            int pastaResultat;
            bool goodPasta = int.TryParse(pastaBakerS, out pastaResultat);
            rat.pastaBaker = pastaResultat;
            Console.WriteLine("girlfriendTaker: ");
            Console.WriteLine(rat.soupMaker + rat.beefSteaker);
            Console.ReadLine();



            Console.ReadLine();

        }
    }
}
