public class ArtifactArchive
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition) //tar lmbda som parameter

    {
        // TODO: Bruk condition til å filtrere og returner en ny liste.

        List<Artifact> matchingArtifacts = new List<Artifact>();


        foreach (Artifact artifact in artifacts)
        {
            if (condition(artifact))
            {
                matchingArtifacts.Add(artifact);
            }
        }
        return matchingArtifacts;
    }
}
