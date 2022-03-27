public class Operation: IMathOperation
{
    internal int Value {get;}
    internal string Name {get;}
    internal string Appearance {get;}

    public Operation(string Name, string appearance)
    {
        // this.Value = val;

    }

    public int Operate(Operation operation)
    {
        throw new NotImplementedException();
    }
}