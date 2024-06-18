namespace InterfaceSegregationPrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.Print("VeArc Secret Project");
            multiFunctionPrinter.Fax("VeArc COE");

            SimplePrinter simplePrinter = new SimplePrinter();
            simplePrinter.Print("VeArc Simple printer");
        }
    }
}
