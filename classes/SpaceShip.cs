public class SpaceShip : GameEntity, IIsControllable
{
    public SpaceShip()
    {
        Name = "Large Male";
        Health = 100;
        Position = (7, 8);
        Parts.Add("Rocket Engine");
        Parts.Add("Wing Left");
        Parts.Add("Wing Right");
        Parts.Add("Rail Gun");
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"SpaceShip {Name} Flies around!");
        base.GameEntityUpdate();
    }
    public void IsControllable()
    {
    }
}