
public class ArtifactArchive
{

    List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Cold Lens", "Europa", 28)
};




    //  klasse inneholder operasjoner og queries mot collectionen.








    //("1 - Show all"

    public List<Artifact> Alleartifacts()
    {

        return new List<Artifact>(artifacts);
    }


    //"2 - Show high risk

    public List<Artifact> artifactsRisk()
    {

        return new List<Artifact>(artifacts.Where(a => a.Risk >= 70).ToList());

    }


    // 3 Search origin"

    public List<Artifact> FindOrgin(string origin)
    {

        if (!string.IsNullOrWhiteSpace(origin))
        {

            return new List<Artifact>(artifacts
                     .Where(a => a.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))
                     .ToList());
        }


        return new List<Artifact>(artifacts);
    }

    //







    public List<Artifact> FindArtifacts(Func<Artifact, bool> condition) //tar lmbda som parameter
    {
        return artifacts.Where(condition).ToList();

    }



}