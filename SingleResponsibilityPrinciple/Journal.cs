using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // breaks single responsibility principle
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public void Load(string filename)
        {
            if (File.Exists(filename))
            {
                var entriesInFile = File.ReadAllLines(filename);
                foreach (var entry in entriesInFile)
                {
                    entries.Add(entry);
                }
            }
        }
    }
}
