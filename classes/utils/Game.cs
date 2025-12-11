public class Game
{
    private List<GameEntity> entities = new List<GameEntity>();

    public void AddEntity(GameEntity entity)
    {
        entities.Add(entity);
    }
    public void UpdateAll()
    {
        foreach (var entity in entities)
        {
            entity.GameEntityUpdate();
            entity.CanExplode();
        }
    }
}