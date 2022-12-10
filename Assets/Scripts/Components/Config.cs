using Unity.Entities;

struct Config : IComponentData
{
    public Entity SoldierPrefab;
    public int SoldierCount;

}