namespace test;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var app = WebApplication.Create();

        app.MapGet("/people", () => new[]
        {
            new Person("Ana"), new Person("Filipe"), new Person("Emillia")
        });

        app.Run();

        record Person(string Name);
    }
}
