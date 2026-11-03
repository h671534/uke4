
public class ArtifactArchive
{

    //  klasse inneholder operasjoner og queries mot collectionen.



    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition) //tar lmbda som parameter
    {
        return artifacts.Where(condition).ToList();
    }

}