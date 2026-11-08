using System.Runtime.InteropServices;



var kall = new ArtifactArchive();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Show all");
    Console.WriteLine("2 - Show high risk");
    Console.WriteLine("3 - Search origin");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        foreach (var artifact in kall.Alleartifacts())
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Origin} | {artifact.Risk}");
        }

    }
    else if (choice == "2")
    {


        foreach (var arti in kall.artifactsRisk())
        {
            Console.WriteLine($"{arti.Name} | {arti.Risk}");
        }
    }
    else if (choice == "3")
    {
        Console.Write("Origin: ");
        string? origin = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(origin))
        {

            Console.WriteLine("Not found ArtifactOrigin");

        }
        else
        {


            foreach (var art in kall.FindOrgin(origin))
            {

                Console.WriteLine("Artifact name er :" + art.Name + " " + art.Origin);
            }
        }


    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}

// TODO: Refaktorer den fungerende monolitten til tydelige ansvar/layers.

