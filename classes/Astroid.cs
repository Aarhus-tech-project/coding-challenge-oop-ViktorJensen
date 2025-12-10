public class Astroid : GameEntity, ICanExplode, ITakeDamage
{
    public Astroid()
    {
        Name = "ASAP Rocky";
        Health = 10;
        Position = (0, 0);
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"Astroid {Name} drifts through space...");
        base.GameEntityUpdate();
    }

    public void TakeDamage()
    {
        
    }
}