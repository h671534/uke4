

using System.Security.Cryptography.X509Certificates;

List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Select til tre ulike projeksjoner.

// LINQ Select brukes til å projisere hvert element i en samling til en ny form. I dette tilfellet kan vi bruke Select til å lage tre ulike projeksjoner av Artifact-objektene.
string[] names = artifacts.Select(a => a.Name).ToArray();

string[] locations = artifacts.Select(a => a.Origin).ToArray();

int[] values = artifacts.Select(a => a.Risk).ToArray();



var formatted = artifacts.Select(a => $"{a.Name} ({a.Origin})");


// TODO: Skriv ut resultatene av hver projeksjon.
Console.WriteLine("Artifact Names:");
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("Artifact Locations:");
foreach (string location in locations)
{
    Console.WriteLine(location);
}
Console.WriteLine("Artifact Risks:");
foreach (int value in values)
{
    Console.WriteLine(value);
}


Console.WriteLine("sekvens med formatterte strings ");

foreach (var f in formatted)
{

    Console.WriteLine(f);
}
