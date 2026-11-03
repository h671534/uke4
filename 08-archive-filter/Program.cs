List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Lag tre separate Where-queries.
var moonArtifacts = artifacts.Where(a => a.Origin == "Moon");
var eArtifacts = artifacts.Where(a => a.Name.Contains("e"));


var highRiskArtifacts = artifacts.Where(a => a.Risk >= 60);


Console.WriteLine("Moon Artifacts:");
foreach (var artifact in moonArtifacts)
{
    Console.WriteLine($"{artifact.Origin} - {artifact.Name}");

}

Console.WriteLine("Artifacts with 'e' in the name:");
foreach (var artifact in eArtifacts)
{
    Console.WriteLine($"{artifact.Name}");
}

Console.WriteLine("High Risk Artifacts (Risk >= 60):");
foreach (var artifact in highRiskArtifacts)
{
    Console.WriteLine($" {artifact.Risk}");
}


