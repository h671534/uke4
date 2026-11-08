public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

    public List<string> GetEntries()//Endre GetEntries() slik at den returnerer en ny liste/kopi av entries.

    {
        // DESIGNFEIL med vilje: denne lekker den interne listen.
        // return entries; //får null reference exception når man prøver å clear den ytre listen, fordi den interne listen blir tømt.

        // Løsning: returner en ny liste som er en kopi av entries.
        // Dette gjør at endringer i den returnerte listen(outsideList) ikke påvirker den interne listen.

        // var copy = new List<string>(entries);// eller kan bruke entries.ToList() for å lage en kopi av listen.


        // return entries; // vi får tom liste 


        List<string> copy = new List<string>(entries);   // får vi 4 i count

        return new List<string>(copy);
    }
}
