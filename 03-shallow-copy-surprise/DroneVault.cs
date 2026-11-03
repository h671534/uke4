public class DroneVault
{
    private List<Drone> drones = new List<Drone>();
    public int Count => drones.Count;

    public void Add(Drone drone)
    {
        drones.Add(drone);
    }

    public List<Drone> GetDrones()
    {
        // TODO: Returner en ny List<Drone> som inneholder samme objekter.

        var copy = new List<Drone>(drones); // Lager en ny liste som er en kopi av den interne listen.
        return new List<Drone>(copy);
    }

    public void PrintAll()
    {
        foreach (Drone drone in drones)
        {
            Console.WriteLine(drone.Name);
        }
    }
}
