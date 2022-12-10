using Unity.Entities;

// Authoring MonoBehaviours are regular GameObject components.
// They constitute the inputs for the baking systems which generates ECS data.
class SoldierAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject WeaponPrefab;
    public UnityEngine.Transform WeaponSpawn;
}

// Bakers convert authoring MonoBehaviours into entities and components.
class SoldierBaker : Baker<SoldierAuthoring>
{
    public override void Bake(SoldierAuthoring authoring)
    {
        AddComponent(new Soldier
        {
             // By default, each authoring GameObject turns into an Entity.
            // Given a GameObject (or authoring component), GetEntity looks up the resulting Entity.
            WeaponPrefab = GetEntity(authoring.WeaponPrefab),
            WeaponSpawn = GetEntity(authoring.WeaponSpawn)
        });
    }
}