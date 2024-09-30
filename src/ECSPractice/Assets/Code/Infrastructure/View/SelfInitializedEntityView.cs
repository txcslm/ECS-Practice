using Code.Common.Entity;
using Code.Infrastructure.Identifiers;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View
{
	public class SelfInitializedEntityView : MonoBehaviour
	{
		public EntityBehaviour EntityBehaviour;
		private IIdentifierService _identifier;

		[Inject]
		public void Construct(IIdentifierService identifier) =>
			_identifier = identifier;

		private void Awake()
		{
			GameEntity entity = CreateEntity.Empty()
				.AddId(_identifier.Next());
			
			EntityBehaviour.SetEntity(entity);
		}
	}
}