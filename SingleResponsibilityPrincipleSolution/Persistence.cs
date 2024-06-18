using SingleResponsibilityPrinciple;

namespace SingleResponsibilityPrincipleSolution
{
    internal class Persistence
    {
        public void SaveToFile(Journal journal, string filename)
        {
            File.WriteAllText(filename, journal.ToString());
        }

    }
}
