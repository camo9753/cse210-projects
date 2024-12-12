using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address instances
        Address address1 = new Address("935 Grubbs St", "Center Point", "IA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 University Blvd", "Rexburg", "ID", "USA");

        // Create Event instances
        Lecture lecture = new Lecture("Tech Talk", "A lecture on modern technology trends", DateTime.Now, "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Event", "An evening to connect with professionals", DateTime.Now.AddDays(1), "6:00 PM", address2, "elonrsvp@gmail.com");
        OutdoorGathering outdoor = new OutdoorGathering("Picnic in the Park", "A fun day with outdoor activities", DateTime.Now.AddDays(2), "12:00 PM", address3, "Sunny");

        // Store events in a list
        List<Event> events = new List<Event> {lecture, reception, outdoor};

        // Display event details
        int eventCount = 1;
        foreach (Event singleEvent in events)
        {
            Console.WriteLine($"Event {eventCount}:\n");
            Console.WriteLine("Standard Details:");
            Console.WriteLine(singleEvent.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(singleEvent.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(singleEvent.GetShortDescription());
            Console.WriteLine("-----------------------------------------\n");
            eventCount++;
        }
    }
}