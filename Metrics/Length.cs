internal class Length: Metric
{
    internal new const string Name = "Длина";

    // max 1M
    // min 1mm
    internal Length (int value): base(Name, value, 100)
    {
    }

    internal override int GenerateEquation()
    {
        var wrontAttempts = 0;

        var dc = Rand.Next(1, 10);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько dm (дециметр) в {dc}M (метр)?", dc * 10);

        var sm = Rand.Next(1, 10);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько cm (сантиметр) в {sm}M (метр)?", sm * Dimension);

        var mm = Rand.Next(3, 78);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько mm (миллиметр) в {mm}cm (сантиметр)?", mm * 10);

        return wrontAttempts;
    }
}