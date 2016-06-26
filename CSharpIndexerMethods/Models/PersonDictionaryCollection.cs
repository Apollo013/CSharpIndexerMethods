using System.Collections;
using System.Collections.Generic;

namespace CSharpIndexerMethods.Models
{
    /// <summary>
    /// Represents a collection of person objects. Uses a string indexing system.
    /// </summary>
    public class PersonDictionaryCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public int Count { get { return listPeople.Count; } }

        // This indexer returns a person based on a string index.
        public Person this[string name]
        {
            get { return (Person)listPeople[name]; }
            set { listPeople[name] = value; }
        }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }

    }
}
