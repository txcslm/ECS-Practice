using Code.Gameplay.Common.Collisions;
using Code.Infrastructure.Registrars;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
	public class EntityBinder : MonoBehaviour, IEntityView
	{
		private GameEntity _entity;
		private ICollisionRegistry _collisionRegistry;

		public GameEntity Entity => _entity;

		[Inject]
		public void Construct(ICollisionRegistry collisionRegistry) =>
			_collisionRegistry = collisionRegistry;

		public void SetEntity(GameEntity entity)
		{
			_entity = entity;
			_entity.AddView(this);
			_entity.Retain(this);

			foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
				registrar.RegisterComponents();

			foreach (Collider2D other in GetComponentsInChildren<Collider2D>(true))
				_collisionRegistry.Register(other.GetInstanceID(), _entity);
		}
		
		public void ReleaseEntity()
		{
			foreach (IEntityComponentRegistrar registrar in GetComponentsInChildren<IEntityComponentRegistrar>())
				registrar.UnregisterComponents();
			
			foreach (Collider2D other in GetComponentsInChildren<Collider2D>(true))
				_collisionRegistry.Unregister(other.GetInstanceID());
			
			_entity.Release(this);
			_entity = null;
		}
	}
}