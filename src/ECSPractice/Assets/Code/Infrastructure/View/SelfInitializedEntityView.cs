using Code.Common.Entity;
using Code.Infrastructure.Identifiers;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Code.Infrastructure.View
{
	public class SelfInitializedEntityView : MonoBehaviour
	{
		public EntityBinder EntityBinder;
		
		private IIdentifierService _identifier;

		[Inject]
		public void Construct(IIdentifierService identifier) =>
			_identifier = identifier;

		private void Awake()
		{
			GameEntity entity = CreateEntity.Empty()
				.AddId(_identifier.Next());
			
			EntityBinder.SetEntity(entity);
		}
	}
}