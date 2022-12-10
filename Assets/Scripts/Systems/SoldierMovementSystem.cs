using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

partial class SoldierMovementSystem : SystemBase
{
    
    protected override void OnUpdate()
    {
        var dt = SystemAPI.Time.DeltaTime;
        Entities
            .WithAll<Soldier>()
            .ForEach((Entity entity, TransformAspect transform) =>
            {
                var pos = transform.Position;
                
                // This does not modify the actual position of the tank, only the point at
                // which we sample the 3D noise function. This way, every tank is using a
                // different slice and will move along its own different random flow field.
                
                pos.y = entity.Index;
              
                var angle = (0.5f + noise.cnoise(pos / 10f)) * 4.0f * math.PI;

                var dir = float3.zero;
                math.sincos(angle, out dir.x, out dir.z);
                transform.Position += dir * dt * 5.0f;
                transform.Rotation = quaternion.RotateY(angle);

            }).ScheduleParallel();
    }
}
