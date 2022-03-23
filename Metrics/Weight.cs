internal class Weight: Metric
{
    // max 1Kg
    // min 1gr
    internal new const string Name = "Вес";
    internal Weight (int value):base(Name, value, 1000)
    {
    }

    internal override void Level1(int rand)
    {
        CmdHelp.AskQuestion($"Сколько gram (грамм) в {rand}Kg (килограмм)?", rand * Dimension);
    }

    internal override void Level2(int rand)
    {
        CmdHelp.AskQuestion($"Сколько Kg (килограмм) в {rand * Dimension}gram (грамм)?", rand);
    }
}