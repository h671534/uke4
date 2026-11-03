List<int> readings = new List<int> { 20, 39, 40, 45, 50, 60, 61, 90 };

// TODO: Send en multi-line lambda til PrintMatching.

// Regelen skal:

// beregne distanceFromCenter = Math.Abs(value - 50)
// lagre en bool som sier om avstanden er maks 10
// returnere bool-verdien

PrintMatching(readings, value =>
{
    int distanceFromCenter = Math.Abs(value - 50);
    bool isWithinRange = distanceFromCenter <= 10;
    return isWithinRange;
});




PrintMatching(readings, value =>
{
    if (value >= 40 && value <= 60)
    {
        return true;
    }
    else
    {
        return false;
    }
});



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
