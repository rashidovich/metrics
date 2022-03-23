internal abstract class Metric
{
    protected Random Rand = new Random();

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

    internal abstract void Level1(int rand);
    internal abstract void Level2(int rand);

    internal virtual void Level3(string question, int expected)
    {

    }

    internal void RunTest()
    {
        Level1(Rand.Next(1, 5));
        Level2(Rand.Next(3, 7));
    }
}