using Code.Gameplay.Features.Enemies.Behaviours;
using Code.Infrastructure.Registrars;

namespace Code.Gameplay.Features.Enemies.Registrars
{
	public class EnemyAnimatorRegistrar : EntityComponentRegistrar
	{
		public EnemyAnimator Animator;
		
		public override void RegisterComponents()
		{
			Entity
				.AddEnemyAnimator(Animator);
		}

		public override void UnregisterComponents()
		{
			Entity
				.RemoveEnemyAnimator();
		}
	}
}