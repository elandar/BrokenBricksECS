﻿using ECS;



namespace ECSExample.Beginner
{
    [DebugSystemGroup("Update")]
    class UpdateFloatSystem : ComponentSystem
    {
        [InjectDependency] UnityEntityManager _entityManager;

        [InjectTuple] ComponentArray<FloatComponent> _floats;

        public override void OnUpdate()
        {
            for (int i = 0; i < _floats.Length; i++) _entityManager.SetComponent(_floats.GetEntity(i), new FloatComponent(_floats[i].value + 1));
        }
    }
}
