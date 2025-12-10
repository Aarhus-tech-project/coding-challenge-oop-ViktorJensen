class Program
{
    static void Main()
    {
        var ship = new SpaceShip { Name = "Falcon", Health = 100, Position = (4, 2)};
        var alien = new Alien {Name = "UFO", Health = 50, Position = (10, 5)};
        var collectable = new Collectable {Name = "Shield", Health = 1, Position = (1, 5)};
        var astroid = new Astroid {Name = "Rocky", Health = 200, Position = (0, 0)};

        ship.AddPart("Rocket Engine");
        ship.AddPart("Wing Right");
        ship.AddPart("Wing Left");
        ship.AddPart("Rail Gun");

        alien.AddPart("Rocket Engine");
        alien.AddPart("Wing Right");
        alien.AddPart("Wing Left");
        alien.AddPart("Laser Gun");
        
        var game = new Game();
        game.AddEntity(ship);
        game.AddEntity(alien);
        game.AddEntity(collectable);
        game.AddEntity(astroid);

        game.UpdateAll();
    }
}