public class Missile : GameEntity, ICanMove, IGiveDamage
{
    public Missile()
    {
        Name = "Missile";
        Health = 1;
        Position = (9, 9);
        Parts.Add("Nuclear warhead");
        Parts.Add("Targeting computer");
    }
    public override void GameEntityUpdate()
    {
        Console.WriteLine($"{Name} Soars towards the Space ship!");
        base.GameEntityUpdate();
    }
    public void CanMove()
    {
        
    }
    public void GiveDamage()
    {
        
    }
}