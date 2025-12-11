public class Alien : GameEntity
{
    public Alien()
    {
        Name = "UFO";
        Health = 75;
        Position = (1, 5);
        Parts.Add("Rocket Engine");
        Parts.Add("Wing Left");
        Parts.Add("Wing Right");
        Parts.Add("Laser Cannon");
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"{Name} hovers menacingly!");
        base.GameEntityUpdate();
    }
}