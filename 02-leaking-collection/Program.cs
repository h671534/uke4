Archive archive = new Archive();

archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");
archive.Add("A-4");

List<string> outsideList = archive.GetEntries();

outsideList.Clear(); // Dette vil tømme  Ytre listen, og dermed også den interne listen i Archive.


// TODO del A: Clear outsideList og observer archive.Count. // 0

// svar        GetEntries() som return entries får 0

// TODO del B: Fiks GetEntries(), og prøv eksperimentet på nytt. // 4

//              GetEntries() som return copy av entries får count 4


Console.WriteLine($"Archive count: {archive.Count}");
