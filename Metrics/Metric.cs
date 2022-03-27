internal abstract class Metric
{
    protected readonly Random Rand = new Random();

    internal Metric(string name, long value, int dimension)
    {
        this.Name = name;
        this.Dimension = dimension;
    }
    
    internal int Dimension { get; private set; }
    internal string Name { get; private set; }
    internal int Value { get; private set; }

    internal bool Assert(int expected, int real)
    {
        return expected == real;
    }

    // returns the number of wrong answered attempts
    internal abstract int GenerateEquation();
}