Console.Clear();
Console.WriteLine("<< Функция f(x) = x * x + 1 >>");
Console.WriteLine();
Console.WriteLine("Введите число x: ");
string name = Console.ReadLine();
double x = Convert.ToDouble(name);

double Fx(double arg)
{
    double result = arg * arg + 1;
    return result;
}

var fxnum = Fx(x);

Console.WriteLine();
Console.WriteLine($"Результат: {fxnum}");
Console.WriteLine();
