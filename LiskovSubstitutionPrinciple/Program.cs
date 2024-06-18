namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 4;
            rect.Height = 5;
            Console.WriteLine($"Rectangle Area: {rect.GetArea()}");

            Rectangle square = new Square();
            square.Width = 5;
            Console.WriteLine($"Square Area: {square.GetArea()}");
        }
    }
}
