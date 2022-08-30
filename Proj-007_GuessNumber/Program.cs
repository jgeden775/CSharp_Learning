Console.Clear();
Console.WriteLine("Введите число от 1 до 10: ");
string name = Console.ReadLine();
int num = Convert.ToInt32(name);
int secnum = 7;
if (num > secnum)
{
    Console.WriteLine("Секретное число меньше.");
}
else if (num < secnum)
{
    Console.WriteLine("Секретное число больше.");
}
else
{
    Console.WriteLine("Ура, вы угадали!");
}
Console.WriteLine(" ");
