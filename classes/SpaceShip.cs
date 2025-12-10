public class SpaceShip : GameEntity, IIsControllable
{
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"SpaceShip {Name} Flies around!");
        base.GameEntityUpdate();
    }
    public void IsControllable()
    {
        
    }
}