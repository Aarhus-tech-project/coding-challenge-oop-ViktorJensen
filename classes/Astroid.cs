public class Astroid : GameEntity, ICanExplode, ITakeDamage
{
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"Astroid {Name} drifts through space...");
        base.GameEntityUpdate();
    }

    public void TakeDamage()
    {
        
    }
}