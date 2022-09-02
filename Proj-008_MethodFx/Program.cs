Console.Clear();
Console.WriteLine("<< Функция f(x) = x * x + 1 >>");
Console.WriteLine();
Console.WriteLine("Введите целое число x: ");
string name = Console.ReadLine();
int x = Convert.ToInt32(name);

int Fx(int arg)
{
    int result = arg * arg + 1;
    return result;
}

int fxnum = Fx(x);

Console.WriteLine();
Console.WriteLine($"Результат: {fxnum}");
Console.WriteLine();
