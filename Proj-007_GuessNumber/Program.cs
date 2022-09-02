Console.Clear();
Console.WriteLine("<< Угадай число >>");
Console.WriteLine();
Console.WriteLine("Введите число от 1 до 10: ");
string name = Console.ReadLine();
int num = Convert.ToInt32(name);
int secnum = new Random().Next(0, 10);
if (num > secnum)
{
    Console.WriteLine($"Увы, вы не угадали. Секретное число {secnum} - меньше");
}
else if (num < secnum)
{
    Console.WriteLine($"Увы, вы не угадали. Секретное число {secnum} - больше");
}
else
{
    Console.WriteLine($"Ура, вы угадали! {secnum} - cекретное число");
}
Console.WriteLine();
