List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");

// Execute Assignment Tasks here!

//-1 The first eruption that is in Chile
IEnumerable<Eruption> FirstEruptionInChile = eruptions.Where(l => l.Location == "Chile").Take(1);
PrintEach(FirstEruptionInChile, "1- The First Eruption In Chile :");

//-2 The first eruption from the Hawaiian Is
bool FirstEruptionInHawai = eruptions.Any(e => e.Location == "Hawaiian Is");
if (FirstEruptionInHawai)
{
    IEnumerable<Eruption> EruptionInHawai = eruptions.Where(l => l.Location == "Hawaiian Is").Take(1);
    PrintEach(EruptionInHawai!, "2- The First Eruption from the Hawaiian Is :");
}
else
{
    System.Console.WriteLine(value: "2- No Hawaiian Is Eruption found.");
}

//-3 The first eruption after 1900 and in New Zealand
Eruption? FirstEruptionAfterInNewZealand = eruptions.Where(y => y.Year > 1900).FirstOrDefault(l => l.Location == "New Zealand");
Console.WriteLine("3- The first eruption after 1900 and in New Zealand :"+FirstEruptionAfterInNewZealand.ToString());

//-4 All eruptions where the volcano's elevation is over 2000m
IEnumerable<Eruption> EruptionElevation = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(EruptionElevation, "4- All eruptions where the volcano's elevation is over 2000m :");

//-5 All eruptions where the volcano's name starts with "L" and Also print the number of eruptions found
IEnumerable<Eruption> EruptionStartWith = eruptions.Where(s => s.Volcano.StartsWith("L"));
PrintEach(EruptionStartWith, "5- All eruptions where the volcano's name starts with 'L' :");
int numberOfEruptions = EruptionStartWith.Count(); 
Console.WriteLine($"Number of eruptions found: {EruptionStartWith.Count()}");

//-6 The highest elevation, and print only that integer 
Int32 EruptionHighestElevation = eruptions.Max(h => h.ElevationInMeters);
System.Console.WriteLine(EruptionHighestElevation);

//-7 The name of the highest Volcano with that elevation
string HighestVolcano = eruptions.Where(h => h.ElevationInMeters == EruptionHighestElevation).First().Volcano;
System.Console.WriteLine("7- The name of the highest Volcano :" + HighestVolcano + " And that elevation :"+EruptionHighestElevation);

//-8 All Volcano names alphabetically
IEnumerable<String> EruptionOrdredName = eruptions.OrderBy(n => n.Volcano).Select(n => n.Volcano);
PrintEach(EruptionOrdredName, "8- All Volcano names alphabetically :");

//-9 All the eruptions that happened before the year 1000 CE alphabetically
IEnumerable<Eruption> EruptionBefor = eruptions.Where(y => y.Year < 1000).OrderBy(n => n.Volcano);
PrintEach(EruptionBefor, "9- All the eruptions that happened before the year 1000 CE alphabetically :");

//-10 All Volcano name that happened before the year 1000 CE alphabetically
IEnumerable<string> NameEruptionBefor = eruptions.Where(y => y.Year < 1000).OrderBy(n => n.Volcano).Select(n => n.Volcano);
PrintEach(NameEruptionBefor, "10- All Volcano name that happened before the year 1000 CE alphabetically :");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

