using Unity.Entities;

class ConfigAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject SnowflakePrefab;
    public int SnowflakeCount;
}

class ConfigBaker : Baker<ConfigAuthoring>
{
    public override void Bake(ConfigAuthoring authoring)
    {
        AddComponent(new Config
        {
            SnowflakePrefab = GetEntity(authoring.SnowflakePrefab),
            SnowflakeCount = authoring.SnowflakeCount
        });
    }
}