internal class Time: Metric
{
    // max 1h
    // min 1sec

    internal new const string Name = "Время";

    internal Time (int value):base(Name, value, 60)
    {
    }

    internal override int GenerateEquation()
    {
        var wrontAttempts = 0;

        var m = Rand.Next(1, 3);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько sec (секундa) в {m}m (минутa)?", m * Dimension);

        var d = Rand.Next(3, 6);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько часов в {d} сутках?", d * 24);

        var weeks = Rand.Next(6, 10);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько дней в {weeks} неделях?", weeks * 7);

        if(weeks % 2 == 0)
            wrontAttempts += CmdHelp.AskQuestion($"Сколько дней в году?", 365, 364);

        return wrontAttempts;
    }
}