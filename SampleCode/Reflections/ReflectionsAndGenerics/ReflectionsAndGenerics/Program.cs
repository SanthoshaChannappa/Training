namespace ReflectionsAndGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = Person.GetNewPerson();

            var t = p.GetType();

            foreach (var prop in t.GetProperties())
            {
                Console.WriteLine("{0} -> {1}", prop.Name, prop.GetValue(p));
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public float Salary { get; set; }

        public static Person GetNewPerson()
        {
            Random r = new Random();
            var id = r.Next();
            return new Person()
            {
                Id = id,
                Name = $"User {id}",
                CreatedOn = DateTime.Now,
                Salary = r.NextSingle() * 10000,
            };
        }
    }
}