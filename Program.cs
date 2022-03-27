using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------------------------------------");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Привет, ты запустил тренажер 'измерений'");
Console.WriteLine("здесь мы с тобой повторим такие величины как:");
Console.WriteLine("");
Console.WriteLine($"{Length.Name}        mm (миллиметр), cm (сантиметр), dm (дециметр), M (метр)");
Console.WriteLine($"{Volume.Name}        ml (миллилитр), L (литр)");
Console.WriteLine($"{Weight.Name}          gram (грамм), Kg (килограмм)");
Console.WriteLine($"{Time.Name}        sec (секунды), m (минуты), h (часы)");
Console.WriteLine($"{Temperature.Name}  градусы цельсия");
Console.WriteLine();
Console.WriteLine("Я работаю в двух режимах: с подсказками (1), без подсказок (2). какой выбираешь?");
Console.WriteLine("(введи 1 или 2 и нажми клавишу 'Enter')");

var regeme = CmdHelp.ReadInt();
Console.WriteLine();

if(regeme <= 1)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"{Length.Name} 1М содержит 10dm, 1dm содержит 10cm, 1cm содержит 10mm");
    Console.WriteLine($"{Volume.Name} 1L содержит 1000ml");
    Console.WriteLine($"{Weight.Name}   1Kg содержит 1000gram");
    Console.WriteLine($"{Time.Name} 1h содержит 60min, 1min содержит 60sec");
    Console.WriteLine("----------------------------------------\n");
}

Console.WriteLine("Cядь поудобнее и приготовься.");
Console.WriteLine("Для старта нажми 'Enter' (НАЗАД ПУТИ НЕТ!!!)");
Console.WriteLine("----------------------------------------");
Console.Read();

var stopwatch = new Stopwatch();
stopwatch.Start();
var wrontAttempts = 0;

wrontAttempts += new Length(1).GenerateEquation();
wrontAttempts += new Volume(1).GenerateEquation();
wrontAttempts += new Weight(1).GenerateEquation();
wrontAttempts += new Temperature(1).GenerateEquation();
wrontAttempts += new Time(1).GenerateEquation();

stopwatch.Stop();
Console.WriteLine($"Молодец, это все. время: {stopwatch.Elapsed.ToString(@"m\:ss")}, количество ошибок: {wrontAttempts}");