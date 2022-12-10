using Unity.Burst;
using Unity.Collections;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;
using UnityEngine;
using Unity.Collections;
using Unity.Entities;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Mathematics;

[BurstCompile]
partial struct SnowflakeSpawningSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var config = SystemAPI.GetSingleton<Config>();

        var ecbSingleton = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>();
        var ecb = ecbSingleton.CreateCommandBuffer(state.WorldUnmanaged);

        var snowflakes = CollectionHelper.CreateNativeArray<Entity>(config.SnowflakeCount, Allocator.Temp);
        ecb.Instantiate(config.SnowflakePrefab, snowflakes);

        Debug.Log($"Spawned {config.SnowflakeCount} snowflakes.");

        // This system should only run once at startup. So it disables itself after one update.
        state.Enabled = false;
    }
}