using SingleResponsibilityPrinciple;

namespace SingleResponsibilityPrincipleSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            journal.AddEntry("Got promotion");
            journal.AddEntry("Now I have a lot of work");
            
            Persistence persistence = new Persistence();
            persistence.SaveToFile(journal, "Work Daires.txt");
        }
    }
}
    