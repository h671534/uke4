using Microsoft.VisualBasic;

public class SpecimenVault
{
    private List<string> specimens = new List<string>();




    public void Add(string specimen)
    {

        if (string.IsNullOrWhiteSpace(specimen))
        {

            Console.WriteLine("Cannot add empty value : 0");
            return;

        }
        else if (specimens.Contains(specimen))
        {

            Console.WriteLine("Cannot add finnes i liste : " + specimen);
            return;

        }
        specimens.Add(specimen);

        Console.WriteLine("Add i liste ;" + specimen);
    }

    public bool Remove(string specimen)
    {
        if (string.IsNullOrWhiteSpace(specimen))
        {

            Console.WriteLine("Cannot remove empty value : 0");

            return false;
        }

        bool removspec = specimens.Remove(specimen); // elemnt som skal fjerne

        if (removspec)
        {

            Console.WriteLine(specimen + " " + "er removed");
        }
        else
        {

            Console.WriteLine(specimen + " " + "er not found i Liste for remov");
        }
        return removspec;




    }

    public void PrintAll()
    {

        if (specimens.Count == 0)
        {
            Console.WriteLine("Listen er tom");
            return;

        }

        foreach (string s in specimens)
        {

            Console.WriteLine("Liste blir nå innhold :" + " " + s);
        }



        // TODO
    }
}
