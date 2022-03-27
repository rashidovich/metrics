internal class Weight: Metric
{
    // max 1Kg
    // min 1gr
    internal new const string Name = "Вес";
    internal Weight (int value):base(Name, value, 1000)
    {
    }

    internal override int GenerateEquation()
    {
        var wrontAttempts = 0;

        var kg = Rand.Next(1, 5);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько gram (грамм) в {kg}Kg (килограмм)?", kg * Dimension);

        var grm = Rand.Next(5, 10);
        wrontAttempts += CmdHelp.AskQuestion($"Сколько Kg (килограмм) в {grm * Dimension}gram (грамм)?", grm);

        return wrontAttempts;
    }
}