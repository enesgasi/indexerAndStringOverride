namespace indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Enes", 22);
            //Console.WriteLine(person1.Name);

            Population newPop = new Population();

            newPop[0] = new Person("Lara", 23);
            newPop[1] = person1;

            Console.WriteLine(newPop[1]);

        }
    }

    public class Population
    {
        public List<Person> personData;

        public Population()
        {
            personData = new List<Person>();
            for (int i = 0; i < 20; i++)
            {
                personData.Add(null);
            }
        }

        public Person this[int index]
        {
            get
            {
                return personData[index];
            }
            set
            {
                personData[index] = value;
            }
        }
    }
    public class Person
    {
        string name;
        int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
