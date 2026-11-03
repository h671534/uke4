ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

// TODO: Kall FindArtifacts med minst tre forskjellige lambdas.

//høy risiko
var highRiskArtifacts = archive.FindArtifacts(a => a.Risk > 70);

// bestemt origin

var moonArtifacts = archive.FindArtifacts(a => a.Origin == "Moon");

// navn som inneholder en tekstbit


var nameContainsArtifacts = archive.FindArtifacts(a => a.Name.Contains("Seed"));//innholder en tekstbit "Seed".



Console.WriteLine("High Risk Artifacts:");
foreach (var artifact in highRiskArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): {artifact.Risk}");
}

Console.WriteLine("Moon Artifacts:");
foreach (var artifact in moonArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): {artifact.Risk}");
}

Console.WriteLine("Artifacts with 'Seed' in the name:");
foreach (var artifact in nameContainsArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): {artifact.Risk}");
}
