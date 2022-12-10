using Unity.Entities;

struct Config : IComponentData
{
    public Entity SnowflakePrefab;
    public int SnowflakeCount;
}