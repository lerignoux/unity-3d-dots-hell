using Unity.Entities;

class SnowflakeAuthoring : UnityEngine.MonoBehaviour
{
}

class SnowflakeBaker : Baker<SnowflakeAuthoring>
{
    public override void Bake(SnowflakeAuthoring authoring)
    {
        AddComponent<Snowflake>();
    }
}