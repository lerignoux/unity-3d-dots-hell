using Unity.Entities;

class TreeAuthoring : UnityEngine.MonoBehaviour
{
}

class TreeBaker : Baker<TreeAuthoring>
{
    public override void Bake(TreeAuthoring authoring)
    {
        AddComponent<HellTree>();
    }
}