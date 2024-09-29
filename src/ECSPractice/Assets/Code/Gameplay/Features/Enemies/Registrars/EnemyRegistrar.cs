using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Features.Enemies.Behaviours;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.Features.Enemies.Registrars
{
	public class EnemyRegistrar : MonoBehaviour
	{
		public float MinSpeed = 0.5f;
		public float MaxSpeed = 2.0f;
		public EnemyAnimator Animator;

		[Inject]
		private IRandomService _random;

		private GameEntity _entity;

		private float Speed => _random.Range(MinSpeed, MaxSpeed);

		private void Awake()
		{
			
			
			_entity = CreateEntity
					.Empty()
					.AddTransform(transform)
					.AddWorldPosition(transform.position)
					.AddDirection(Vector2.zero)
					.AddSpeed(Speed)
					.AddEnemyAnimator(Animator)
					.AddSpriteRenderer(Animator.SpriteRenderer)
					.With(x => x.isEnemy = true)
					.With(x => x.isTurnedAlongDirection = true)
					.With(x => x.isMoving = true)
				;
		}
	}
}