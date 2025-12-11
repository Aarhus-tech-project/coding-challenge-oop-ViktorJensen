public abstract class GameEntity : ICanExplode, ITakeDamage
{
    public (float X, float Y) Position { get; set;}
    public int Health { get; set;}
    public string? Name { get; set;}

    public List<string> Parts { get; private set; } = new List<string>();

    protected void AddPart(string partName)
    {
        Parts.Add(partName);
    }
    protected void UpdateParts()
    {
        foreach (var part in Parts)
        {
            Console.WriteLine($"    Part: {part}");
        }
    }
    public virtual void GameEntityUpdate()
    {
        UpdateParts();
    }
    public void CanExplode()
    {
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} Exploded!");
        }
    }
    public void TakeDamage()
    {
    }
}