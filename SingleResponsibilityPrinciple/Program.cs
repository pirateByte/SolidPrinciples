namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.AddEntry("Got promotion");
            journal.AddEntry("Now I have a lot of work");
            journal.Save("Work Daires.txt");
        }
    }
}
