ArtifactArchive archive = new ArtifactArchive();

archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));
archive.Add(new Artifact("Dust Stone", "Mars", 65));

// TODO: Kall FindArtifacts med minst tre forskjellige lambdas.

//høy risiko//     er det mulig å sette inn highRiskArtifacts i var ?

List<Artifact> highRiskArtifacts = archive.FindArtifacts(a => a.Risk > 70);

// bestemt origin

List<Artifact> moonArtifacts = archive.FindArtifacts(a => a.Origin == "Moon");

// navn som inneholder en tekstbit


List<Artifact> nameContainsArtifacts = archive.FindArtifacts(a => a.Name.Contains("Stone"));//innholder en tekstbit "Seed".



Console.WriteLine("High Risk Artifacts (Risk > 70):");

foreach (Artifact artifact in highRiskArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): {artifact.Risk}");
}

Console.WriteLine("Moon Artifacts:");

foreach (Artifact artifact in moonArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): {artifact.Risk}");
}

Console.WriteLine("Artifacts with 'Stone' in the name:");

foreach (Artifact artifact in nameContainsArtifacts)
{
    Console.WriteLine($"- {artifact.Name} ({artifact.Origin}): ");
}
