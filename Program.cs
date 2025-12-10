class Program
{
    static void Main()
    {
        var game = new Game();
        game.AddEntity(new SpaceShip {});
        game.AddEntity(new Alien {});
        game.AddEntity(new Astroid {});
        game.AddEntity(new Collectable {});

        game.UpdateAll();
    }
}