using System.Text;

internal class Temperature: Metric
{ 
    const string Celsius = "В градусах Цельсия";
    private static readonly IList<string> Variants = new List<string> {
        "В миллиметрах Путина",
        "В усах Лукашенко",
        "В коллиграммах Соловьева",
        "В храбрости Зеленского",
        "В Славе Украины",
        "В способностях Папы",
        "В красоте Мамы",
        Celsius
    };

    internal new const string Name = "Температура";

    internal Temperature (int value): base(Name, value, 1)
    {
    }

    internal override int GenerateEquation()
    {
        var wrontAttempts = 0;
        var randomizedVariants = Variants.OrderBy(item => Rand.Next()).ToList();
        var question = new StringBuilder("В чем измеряется температура? Выбери правильный вариант\n\n");
        int correctVariantIndex = 0;

        for(var index = 0; index < randomizedVariants.Count(); index++)
        {
            question.Append($"{index}. {randomizedVariants[index]}\n");

            if(randomizedVariants[index].Equals(Celsius))
            {
                correctVariantIndex = index;
            }
        }

        wrontAttempts += CmdHelp.AskQuestion(question.ToString(), correctVariantIndex);
        return wrontAttempts;
    }
}