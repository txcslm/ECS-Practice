using Code.Common.Destruct.Systems;
using Code.Gameplay.Features.Abilities.System;
using Code.Infrastructure.Systems;

namespace Code.Common.Destruct
{
  public sealed class ProcessDestructedFeature : Feature
  {
    public ProcessDestructedFeature(ISystemFactory systems)
    {
      Add(systems.Create<SelfDestructTimerSystem>());
      Add(systems.Create<FrozenBoltExplosionAbilitySystem>());
      Add(systems.Create<CleanupGameDestructedViewSystem>());
      Add(systems.Create<CleanupGameDestructedSystem>());
    }
  }
}