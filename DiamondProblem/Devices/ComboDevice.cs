using System;

namespace DiamondProblem.Devices {
    class ComboDevice : Device, IScanner, IPrinter {
        public override void ProcessDoc(string document) {
            Console.WriteLine("Combo device processing: " + document);
        }

        public void Print(string document) {
            Console.WriteLine("Combo device print: " + document);
        }        

        public string Scan() {
            return "Combo device scan";
        }
    }
}
