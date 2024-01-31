using Calculator.Model;

namespace Calculator.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService

    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> lPersons = new List<Person>();
            for (int i = 0; i< 8; i++ )
            {
                Person person = MockPerson(i);
                lPersons.Add(person);
            }
            return lPersons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Bethânia",
                LastName = "Freitas",
                Address = "Atibaia - SP",
                Gender = "Female"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Bethânia" + i,
                LastName = "Freitas" + i,
                Address = "Atibaia - SP" + i,
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
