using Entitas;

namespace Code.Gameplay.Features.Enemies.Systems
{
	public class FollowHeroByDirectionSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _enemies;
		private readonly IGroup<GameEntity> _heroes;

		public FollowHeroByDirectionSystem(GameContext game)
		{
			_enemies = game.GetGroup(GameMatcher
					.AllOf(
						GameMatcher.Enemy,
						GameMatcher.Direction,
						GameMatcher.WorldPosition,
						GameMatcher.Moving))
				;

			_heroes = game.GetGroup(GameMatcher
				.AllOf(
					GameMatcher.Hero,
					GameMatcher.WorldPosition));
		}

		public void Execute()
		{
			foreach (GameEntity hero in _heroes)
			foreach (GameEntity enemy in _enemies)
			{
				if (enemy.isMoving)
					enemy.ReplaceDirection((hero.WorldPosition - enemy.WorldPosition).normalized);
			}
		}
	}
}