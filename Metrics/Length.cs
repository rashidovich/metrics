internal class Length: Metric
{
    internal new const string Name = "Длина";

    // max 1M
    // min 1mm
    internal Length (int value): base(Name, value, 100)
    {
    }

    internal override void Level1(int rand)
    {
        CmdHelp.AskQuestion($"Сколько dm (дециметр) в {rand}M (метр)?", rand * 10);
    }

    internal override void Level2(int rand)
    {
        CmdHelp.AskQuestion($"Сколько cm (сантиметр) в {rand}M (метр)?", rand * Dimension);

        var cm = Rand.Next(3, 78);
        CmdHelp.AskQuestion($"Сколько mm (миллиметр) в {cm}cm (сантиметр)?", cm * 10);
    }   

    internal virtual void Level3()
    {

    } 
}