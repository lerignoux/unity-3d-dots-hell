using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

// Instead of directly accessing the Soldier component, we are creating an aspect.
// Aspects allows you to provide a customized API for accessing your components.
readonly partial struct SoldierAspect : IAspect
{
    // This reference provides read only access to the Soldier component.
    // Trying to use ValueRW (instead of ValueRO) on a read-only reference is an error.
    readonly RefRO<Soldier> m_Soldier;

    // Note the use of ValueRO in the following properties.
    public Entity WeaponSpawn => m_Soldier.ValueRO.WeaponSpawn;
    public Entity WeaponPrefab => m_Soldier.ValueRO.WeaponPrefab;
}
