using System.Collections;

namespace CSharpIndexerMethods.Models
{

    /// <summary>
    /// Represents a collection of person objects. Uses numeric indexing system.
    /// </summary>
    public class PersonCollection : IEnumerable
    {
        private ArrayList People = new ArrayList();

        public int Count { get { return People.Count; } }

        // Custom Indexer for class

        public Person this[int index]
        {
            get { return (Person)People[index]; }
            set { People.Insert(index, value); }
        }

        // Cast for caller. / unbox
        public Person GetPerson(int pos)
        {
            return (Person)People[pos];
        }

        // Insert only Person objects.
        public void AddPerson(Person p)
        {
            People.Add(p);
        }

        public void ClearPeople()
        {
            People.Clear();
        }

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return People.GetEnumerator();
        }
    }
}
