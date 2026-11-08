List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Any og Count til å svare på spørsmålene.

//Finnes minst ett artifact med Risk > 90? Bruk Any.?

bool hasHighRiskArtifact = artifacts.Any(a => a.Risk > 90);
Console.WriteLine($"Finnes minst ett artifact med Risk > 90? {hasHighRiskArtifact}");

//Hvor mange artifacts har Origin "Mars"? Bruk Count.

int marsArtifactCount = artifacts.Count(a => a.Origin == "Mars");//count() har en bestemt krav ikke alle origin
Console.WriteLine($"Antall artifacts med Origin 'Mars': {marsArtifactCount}");

//Hvor mange artifacts finnes totalt? Bruk Count uten parameter.// count() har ikke krav inn (),da skriver ut Alle antall i artifacts
int totalArtifactCount = artifacts.Count();
Console.WriteLine($"Totalt antall artifacts: {totalArtifactCount}");

//Finnes minst ett artifact fra Venus?
bool hasVenusArtifact = artifacts.Any(a => a.Origin == "Venus");


Console.WriteLine($"Finnes minst ett artifact fra Venus? {hasVenusArtifact}");



// //
// Console.WriteLine("Artifacts with Risk > 90:");
// foreach (var artifact in artifacts.Where(a => a.Risk > 90))
// {
//     Console.WriteLine($"{artifact.Name} - Risk: {artifact.Risk}");
// }

// Console.WriteLine("Artifacts with Origin 'Mars':");
// foreach (var artifact in artifacts.Where(a => a.Origin == "Mars"))
// {
//     Console.WriteLine($"{artifact.Name} - Origin: {artifact.Origin}");
// }

// Console.WriteLine("Total number of artifacts:");
// foreach (var artifact in artifacts)
// {
//     Console.WriteLine($"{artifact.Name} - Origin: {artifact.Origin} - Risk: {artifact.Risk}");
// }

// Console.WriteLine("Artifacts from Venus:");
// foreach (var artifact in artifacts.Where(a => a.Origin == "Venus"))
// {
//     Console.WriteLine($"{artifact.Name} - Origin: {artifact.Origin}");
// }
