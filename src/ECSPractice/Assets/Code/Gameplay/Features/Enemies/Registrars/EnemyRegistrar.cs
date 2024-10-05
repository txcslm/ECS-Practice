using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemies.Behaviours;
using Code.Infrastructure.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Enemies.Registrars
{
	public class EnemyRegistrar : EntityComponentRegistrar
	{
		public float MinSpeed = 0.5f;
		public float MaxSpeed = 2.0f;

		[Inject]
		private IRandomService _random;

		private float Speed => _random.Range(MinSpeed, MaxSpeed);
		

		public override void RegisterComponents()
		{
			Entity.
				AddWorldPosition(transform.position)
				.AddDirection(Vector2.zero)
				.AddSpeed(Speed)
				.With(x => x.isEnemy = true)
				.With(x => x.isTurnedAlongDirection = true)
				.With(x => x.isMoving = true)
				;
		}

		public override void UnregisterComponents()
		{
			
		}
	}
}