using Unity.Entities;
using Unity.Rendering;

class WeaponAuthoring : UnityEngine.MonoBehaviour
{
}

class WeaponBaker : Baker<WeaponAuthoring>
{
    public override void Bake(WeaponAuthoring authoring)
    {
        // By default, components are zero-initialized.
        // So in this case, the Speed field in CannonBall will be float3.zero.
        AddComponent<Weapon>();
    }
}
