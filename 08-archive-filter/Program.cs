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
string[] moonArtifacts = artifacts.Where(a => a.Origin == "Moon").Select(a => a.Name).ToArray();


string[] eArtifacts = artifacts.Where(a => a.Name.Contains("e") || a.Name.Contains("E")).Select(a => a.Name).ToArray();

int[] highRiskArtifacts = artifacts.Where(a => a.Risk >= 60).Select(a => a.Risk).ToArray();


Console.WriteLine("Moon Artifacts:");
foreach (string artifact in moonArtifacts)
{
    Console.WriteLine($"{artifact}");

}

Console.WriteLine("Artifacts with 'e' or 'E' in the name:");
foreach (string artifact in eArtifacts)
{
    Console.WriteLine($"{artifact}");
}

Console.WriteLine("High Risk Artifacts (Risk >= 60):");
foreach (int artifact in highRiskArtifacts)
{
    Console.WriteLine($" {artifact}");
}




