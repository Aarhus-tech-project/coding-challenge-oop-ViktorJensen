public class SpaceMine : GameEntity, IGiveDamage
{
    public SpaceMine()
    {
        Name = "Mine";
        Health = 1;
        Position = (10, 8);
        Parts.Add("Insta WormHole C4");
        Parts.Add("Red Light");
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"{Name} Blinks red in the distance!");
        base.GameEntityUpdate();
    }
    public void GiveDamage()
    {
        
    }
}