class Program
{
    public static void SetPersonFirstName(Person person, string firstName)
    {
        person.SetFirstName(firstName);
    }
    public static void Main(string[] args)
    {
        Person bob = new Person("Bob", "Billy", 37);
        // Console.WriteLine(bob.GetPersonInfo());

        Doctor doctorBob = new Doctor("Jerry", "Budge", 65, "Hack Saw");
        // Console.WriteLine(doctorBob.GetDoctorInfo());
        // Console.WriteLine(doctorBob.GetPersonInfo());

        Police policeDoug = new Police("Doug", "Denver", 40, "Colt 1911");
        // Console.WriteLine(policeDoug.GetPoliceInfo());
        // Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(policeDoug, "Doug the 2nd");
        // Console.WriteLine(policeDoug.GetPoliceInfo());
        // Console.WriteLine(policeDoug.GetPersonInfo());

        SetPersonFirstName(bob, "Bobby");
        Console.WriteLine(bob.GetPersonInfo());

        List<Person> people = new List<Person>();
        people.Add(bob);
        people.Add(doctorBob);
        people.Add(policeDoug);

        Console.WriteLine("List:");
        foreach(Person person in people)
        {
            Console.WriteLine(person.GetPersonInfo());
        }

    }
}