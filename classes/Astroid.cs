public class Astroid : GameEntity, IGiveDamage, ICanMove
{
    public Astroid()
    {
        Name = "ASAP Rocky";
        Health = 10;
        Position = (0, 0);
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"{Name} drifts through space...");
        base.GameEntityUpdate();
    }
    public void GiveDamage()
    {
        
    }
    public void CanMove()
    {
        
    }
}