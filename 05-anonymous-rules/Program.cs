List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7, 24, 36 };


// TODO: Kall PrintMatching minst tre ganger med ulike lambdas.
PrintMatching(readings, value => value > 20 && value < 40); // Lambda uttrykk som sjekker om verdien er mellom 20 og 40.
PrintMatching(readings, value => value % 2 == 0); // Lambda uttrykk er partallige tall.
PrintMatching(readings, value => value > 50); // Lambda uttrykk som sjekker om verdien er større enn 50.


static void PrintMatching(List<int> values, Func<int, bool> condition)
{
    foreach (int value in values)
    {
        if (condition(value))
        {
            Console.WriteLine(value);
        }
    }
}
