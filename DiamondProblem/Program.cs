using System;
using DiamondProblem.Devices;

namespace DiamondProblem {
    class Program {
        static void Main(string[] args) {
            Printer p = new Printer() { SerialNumber = "1080" };
            p.ProcessDoc("My letter");
            p.Print("My printer");

            Scanner s = new Scanner() { SerialNumber = "2003" };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = "2019" };
            c.ProcessDoc("My test");
            c.Print("My combo device printer");
            Console.WriteLine(c.Scan());
        }
    }
}
