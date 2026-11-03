

DroneVault vault = new DroneVault();

vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));
vault.Add(new Drone("Alpha"));

List<Drone> copy = vault.GetDrones(); // copy er ytre liste,vault er indre liste. 

copy.RemoveAt(0); // Fjerner den første dronen fra kopien kan ikke påvirke den interne listen i DroneVault fordi vi returnerer en ny liste som er en kopi av den interne listen.

copy[0].Name = "Foxtrot"; // Endrer navnet på den første dronen i kopien kan påvirke den interne listen i DroneVault fordi vi returnerer en ny liste som inneholder referanser til de samme Drone-objektene.


// TODO: Eksperimenter med RemoveAt og deretter endring av Name.


Console.WriteLine($"Vault count: {vault.Count}");
vault.PrintAll();
