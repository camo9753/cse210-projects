class Program
{
    public static void Main(string[] args)
    {
        Person bob = new Person("Bob", "Billy", 37);
        Console.WriteLine(bob.GetPersonInfo());

        Doctor doctorbob = new Doctor("Jerry", "Budge", 65, "Hack Saw");
        Console.WriteLine(doctorbob.GetDoctorInfo());
        Console.WriteLine(doctorbob.GetPersonInfo());

        Police policeDoug = new Police("Doug", "Denver", 40, "Colt 1911");
        Console.WriteLine(policeDoug.GetPoliceInfo());
        Console.WriteLine(policeDoug.GetPersonInfo());


    }
}