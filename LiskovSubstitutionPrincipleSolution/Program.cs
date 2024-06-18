namespace LiskovSubstitutionPrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle { Width = 4, Height = 5 };
            Console.WriteLine($"Rectangle Area: {rect.GetArea()}");

            IShape square = new Square { SideLength = 5 };
            Console.WriteLine($"Square Area: {square.GetArea()}");
        }
    }
}
