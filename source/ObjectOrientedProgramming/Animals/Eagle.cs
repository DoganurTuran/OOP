namespace ObjectOrientedProgramming;

public sealed class Eagle : Animal
{
    public Eagle() : base(nameof(Eagle)) { }

    public override void Move()
    {
        Console.WriteLine("Flying");
    }

    public override void Sound()
    {
        Console.WriteLine("Screech");
    }
}
