Console.WriteLine("Starting GitWitIt...");

string name;
do
{
    Console.Write("Please enter your name: ");
    name = Console.ReadLine();
} while (string.IsNullOrWhiteSpace(name));

Console.WriteLine($"Hello, {name}!");

Console.WriteLine("Done! Thanks for using GitWitIt.");