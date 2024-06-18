using System.Reflection.Metadata;

namespace InterfaceSegregationPrinciple
{
    internal interface IMultiFunctionPrinter
    {
        void Print(string document);
        void Scan(string document);
        void Fax(string document);
        void Copy(string document);
    }
}
