using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class SimplePrinter : IMultiFunctionPrinter
    {
        public void Copy(string document)
        {
            throw new NotImplementedException();
        }

        public void Fax(string document)
        {
            throw new NotImplementedException();
        }

        public void Print(string document)
        {
            Console.WriteLine("Printing " + document);
        }

        public void Scan(string document)
        {
            throw new NotImplementedException();
        }
    }
}
