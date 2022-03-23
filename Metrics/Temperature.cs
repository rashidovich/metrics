internal class Temperature: Metric
{ 
    internal new const string Name = "Температура";

    internal Temperature (int value): base(Name, value, 1)
    {
    }

    internal override void Level1(int rand)
    {
        throw new NotImplementedException();
    }

    internal override void Level2(int rand)
    {
        throw new NotImplementedException();
    }
}