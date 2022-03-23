internal class Time: Metric
{
    // max 1h
    // min 1sec

    internal new const string Name = "Время";

    internal Time (int value):base(Name, value, 60)
    {
    }

    internal override void Level1(int rand)
    {
        CmdHelp.AskQuestion($"Сколько sec (секундa) в {rand}m (минутa)?", rand * Dimension);
    }

    internal override void Level2(int rand)
    {
        CmdHelp.AskQuestion($"Сколько часов в {rand} сутках?", rand * 24);

        var weeks = Rand.Next(1, 9);
        CmdHelp.AskQuestion($"Сколько дней в {weeks} неделях?", weeks * 7);

        if(weeks % 2 == 0)
            CmdHelp.AskQuestion($"Сколько дней в году?", 365, 364);
    }
}