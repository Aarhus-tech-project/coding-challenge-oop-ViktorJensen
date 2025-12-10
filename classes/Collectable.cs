public class Collectable : GameEntity, ICanExplode
{
    public Collectable()
    {
        Name = "Shield";
        Health = 1;
        Position = (4, 6);
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"PowerUp {Name} shines!");
        base.GameEntityUpdate();
    }
}