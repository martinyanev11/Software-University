using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public List<Renovator> Renovators { get; set; }

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count
        {
            get { return Renovators.Count; }
            set { Count = value; }
        }

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            else if (Renovators.Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                Renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            if (Renovators.Any(x => x.Name == name))
            {
                int indexToRemove = Renovators.FindIndex(x => x.Name == name);
                Renovators.RemoveAt(indexToRemove);
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            if (Renovators.Any(x => x.Type == type))
            {
                int countBeforeRemoving = Renovators.Count;

                Renovators.RemoveAll(x => x.Type == type);
                return countBeforeRemoving - Renovators.Count;
            }
            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            foreach (Renovator renovator in Renovators)
            {
                if (renovator.Name == name)
                {
                    renovator.Hired = true;
                    return renovator;
                }
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> filteredByDays = Renovators.Where(x => x.Days >= days).ToList();

            return filteredByDays;
        }

        public string Report()
        {
            Console.WriteLine($"Renovators available for Project {Project}:");

            List<Renovator> filtered = Renovators.Where(x => x.Hired == false).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var renovater in filtered)
            {
                sb.AppendLine(renovater.ToString());
            }

            return sb.ToString();
        }
    }
}
