using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincipleSolution
{
    internal class MultiFunctionPrinter : IPrinter, IScanner, IFax, ICopier
    {
        public void Print(string document)
        {
            Console.WriteLine("Printing " + document);
        }

        public void Scan(string document)
        {
            Console.WriteLine("Scanning " + document);
        }

        public void Fax(string document)
        {
            Console.WriteLine("Faxing " + document);
        }

        public void Copy(string document)
        {
            Console.WriteLine("Copying " + document);
        }
    }
}
