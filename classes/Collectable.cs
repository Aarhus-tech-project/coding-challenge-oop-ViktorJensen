public class Collectable : GameEntity, ICanExplode
{
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"PowerUp {Name} shines!");
        base.GameEntityUpdate();
    }
}