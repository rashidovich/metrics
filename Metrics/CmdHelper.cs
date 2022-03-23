internal static class CmdHelp
{
    internal static int ReadInt()
    {
        var str = Console.ReadLine();

        if(int.TryParse(str?.Trim(), out var val))
        {
            return val;
        }

        Console.Write($"Не могу разобрать, попробуй еще раз: ");
        return ReadInt();
    }

    internal static void AskQuestion(string question, params int[] expected)
    {
        while(true)
        {
            Console.WriteLine(string.Format(question));
            var response = CmdHelp.ReadInt();

            if(Assert(response, expected))
            {
                Console.WriteLine("Правильно!");
                Console.WriteLine("----------------------------------------");
                break;
            }
            else
            {
                Console.WriteLine("Неверно! Еще раз.");
            }
        }
    }    

    internal static bool Assert(int real, params int[] expected)
    {
        return expected.Contains(real);
    }    
}