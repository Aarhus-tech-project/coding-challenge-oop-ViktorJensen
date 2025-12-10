public class Alien : GameEntity
{
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"Alien {Name} hovers menacingly!");
        base.GameEntityUpdate();
    }
}