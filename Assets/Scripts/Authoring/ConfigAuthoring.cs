using Unity.Entities;

class ConfigAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject SoldierPrefab;
    public int SoldierCount;
}

class ConfigBaker : Baker<ConfigAuthoring>
{
    public override void Bake(ConfigAuthoring authoring)
    {
        AddComponent(new Config
        {
            SoldierPrefab = GetEntity(authoring.SoldierPrefab),
            SoldierCount = authoring.SoldierCount,

        });
    }
}
