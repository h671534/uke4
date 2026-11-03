List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};





// TODO: Where -> OrderBy -> Select.
// Hent artifacts med Risk >= 30 og sorter dem etter Risk. //Artifact produser objekter med Risk >= 30 .
var beholderArtifacts = artifacts.Where(a => a.Risk >= 30)
    .OrderBy(a => a.Risk)
    .Select(a => new { a.Name, a.Origin, a.Risk });

//sorterer dem alfabetisk på Name // Artifact produser objekter med Risk >= 30 og sorter dem alfabetisk på Name. 
beholderArtifacts = beholderArtifacts.OrderBy(a => a.Name);

//projiserer dem til strings som "Name: Risk" // Attifact produser strings som "Name: Risk".
var artifactStrings = beholderArtifacts.Select(a => $"{a.Name}: {a.Risk}");





//Lagre resultatet og iterer over det.
foreach (var artifactString in artifactStrings)
{
    Console.WriteLine(artifactString);
}

//Lag deretter en ny chain som sorterer alle artifacts på Risk.
var sortedArtifacts = artifacts.OrderBy(a => a.Risk)
    .Select(a => new { a.Name, a.Origin, a.Risk });
