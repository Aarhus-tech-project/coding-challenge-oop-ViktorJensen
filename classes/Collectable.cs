public class Collectable : GameEntity
{
    public Collectable()
    {
        Name = "PowerUp";
        Health = 1;
        Position = (4, 6);
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"{Name} Glows!");
        base.GameEntityUpdate();
    }
}