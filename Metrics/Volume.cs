internal class Volume: Metric
{
    // max 1L
    // min 1ml

    internal new const string Name = "Обьем";
    internal Volume (int value):base(Name, value, 1000)
    {
    }

    internal override int GenerateEquation()
    {
        var wrontAttempts = 0;

        var l = Rand.Next(1, 5);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько ml (миллилитр) в {l} (литр)?", l * Dimension);

        var ml = Rand.Next(5, 10);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько L (литр) в {ml * Dimension}ml (миллилитр)?", ml);

        return wrontAttempts;
    }
}