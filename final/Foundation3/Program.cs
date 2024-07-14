// Main program
public class Program
{
    public static void Main()
    {
        Address lectureAddress = new Address("123 University Ave", "Cityville", "State", "Country");
        Event lecture = new Lecture("Science Lecture", "A lecture on modern science.", new DateTime(2024, 8, 1), "10:00 AM", lectureAddress, "Dr. John Doe", 100);

        Address receptionAddress = new Address("456 Party St", "Townsville", "State", "Country");
        Event reception = new Reception("Company Reception", "An evening reception for company employees.", new DateTime(2024, 8, 2), "7:00 PM", receptionAddress, "rsvp@company.com");

        Address outdoorGatheringAddress = new Address("789 Park Ave", "Villagetown", "State", "Country");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun outdoor picnic for the community.", new DateTime(2024, 8, 3), "12:00 PM", outdoorGatheringAddress, "Sunny and warm");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("--------------------------------------------------");
        }
    }
}