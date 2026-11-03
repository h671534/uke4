List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7 };


PrintMatching(readings, IsHighReading);

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

static bool IsHighReading(int value)//  metode kan behandles som en verdi som sendes til en annen metode som tar en funksjon som parameter. Dette er et eksempel på høyere ordens funksjoner i C#.
{


    if (value >= 60)
    {
        return true;
    }
    else
    {
        return false;
    }
    // TODO: Definer "high" som minst 60.

}
