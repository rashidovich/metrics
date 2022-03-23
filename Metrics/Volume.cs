internal class Volume: Metric
{
    // max 1L
    // min 1ml

    internal new const string Name = "Обьем";
    internal Volume (int value):base(Name, value, 1000)
    {
    }

    internal override void Level1(int rand)
    {
        CmdHelp.AskQuestion($"Сколько ml (миллилитр) в {rand} (литр)?", rand * Dimension);
    }

    internal override void Level2(int rand)
    {
        CmdHelp.AskQuestion($"Сколько L (литр) в {rand * Dimension}ml (миллилитр)?", rand);
    }
}