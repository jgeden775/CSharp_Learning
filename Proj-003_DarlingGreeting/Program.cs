Console.Clear();
Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "john")
{
    Console.WriteLine("Hey Johnny buddy! How are you?");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username + "!");
}
Console.WriteLine(" ");
