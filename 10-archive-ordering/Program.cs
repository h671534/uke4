List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};





// TODO: Where -> OrderBy -> Select.
// Hent artifacts med Risk >= 30 og sorter dem etter Risk. //Artifact produser objekter med Risk >= 30 .


// int[] beholderArtifacts = artifacts.Where(a => a.Risk >= 30).Select(a => a.Risk).ToArray();

var beholderArtifacts = artifacts.Where(a => a.Risk >= 30)
    .OrderBy(a => a.Risk)
    .Select(a => new { a.Name, a.Origin, a.Risk });


var beholderArtifacs2 = artifacts.Where(a => a.Risk >= 30)
.OrderBy(a => a.Name).Select(a => new { a.Name, a.Origin, a.Risk });

var allartifacts = artifacts.OrderBy(a => a.Risk).Select(a => new { a.Name, a.Origin, a.Risk });



// Console.WriteLine("Artifacts with Risk >= 30, sorted by Risk:" + beholderArtifacts);

//sorterer dem alfabetisk på Name // Artifact produser objekter med Risk >= 30 og sorter dem alfabetisk på Name. 

//projiserer dem til strings som "Name: Risk" // Attifact produser strings som "Name: Risk".

var artifactStrings = artifacts.Where(a => a.Risk >= 30)
.Select(a => $"{a.Name}: {a.Risk}");

var Allartifact = artifacts.Select(a => $"{a.Name}: {a.Risk}");


Console.WriteLine(" Alle Artifacts med form Name: Risk ");
foreach (var allarti in Allartifact)
{

    Console.WriteLine(allarti);
}




foreach (var artifactString in beholderArtifacts)
{
    Console.WriteLine("Artifact med Risk >= 30, sorted by Risk: " + artifactString);
}

Console.WriteLine();


foreach (var artifactString2 in beholderArtifacs2)
{
    Console.WriteLine("Artifact med Risk >= 30, sorted by Name: " + artifactString2);
}


Console.WriteLine("artifacts med Risk >= 30  Name: Risk");

foreach (var arti in artifactStrings)
{

    Console.WriteLine(arti);
}

Console.WriteLine("sorterer alle artifacts på Risk.");


foreach (var artirisk in allartifacts)
{

    Console.WriteLine(artirisk);
}



// //Lag deretter en ny chain som sorterer alle artifacts på Risk.
// var sortedArtifacts = artifacts.OrderBy(a => a.Risk)
//     .Select(a => new { a.Name, a.Origin, a.Risk });
