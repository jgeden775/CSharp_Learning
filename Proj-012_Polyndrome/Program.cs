Console.Clear();
Console.WriteLine("<< Является ли слово или число полиндромом? >>");
Main();

void Main()
{
string text = Input();
Process(text);
Exit();
}

string Input()
{
Console.WriteLine();
Console.WriteLine("Введите ОДНО слово или число: ");
string word = Console.ReadLine();
Console.WriteLine();
return word;
}

void Process(string word)
{
    if (word.Length < 2)
    {
        Console.WriteLine("Тут всего один символ. Определить полиндром не получится.");
        Console.WriteLine();
        Exit(); // После закрытия выдаст ошибки, надо подумать как исправить
    }

    bool space = false;
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == ' ') space = true;
    }

    if (space == true)
    {
       Console.WriteLine("Можно ввести только ОДНО слово или число!");
       Console.WriteLine();
    }
    else
    {
        if (word[0] == word[word.Length - 1] & word[1] == word[word.Length - 2])
        {
            Console.WriteLine("Это ПОЛИНДРОМ.");
            Console.WriteLine();
        }
        else 
        {
            System.Console.WriteLine("Это НЕ ПОЛИНДРОМ.");
            Console.WriteLine();
        }
    }
}

void Exit()
{
    Console.Write("Зажмите [Esc] для выхода или нажмите [Enter] для перезапуска программы.");
    Console.WriteLine();
    if (Console.ReadKey().Key == ConsoleKey.Enter) Main();
    while (Console.ReadKey().Key != ConsoleKey.Escape) {} // Как вариант сделать через Environment.Exit(0);
}