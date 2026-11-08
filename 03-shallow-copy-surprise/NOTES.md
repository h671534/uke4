# Notater

- TODO: Hva skjer med selve listen?

List<Drone> copy = vault; // begge to lister peker til samme referance type//her kan copy.RemoveAt(0); endre antall elemner i vault liste

men med

List<Drone> copy = new List<Drone>(valut);// da får du en helt ny liste med samme elementer.her kan copy.RemoveAt(0); kan endre ikke antall elemneter i vault liste som vi gjørt nå.

copy[0].Name = "Foxtrot";

vil elment i copy endre fordi deler samme objektreferanser. Name

- TODO: Hva skjer med objektene i listen?
