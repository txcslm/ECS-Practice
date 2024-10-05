using System;
using Entitas;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Code.Infrastructure.View
{
	public abstract class EntityDependant : MonoBehaviour
	{
		public EntityBinder EntityBinder;
		
		public GameEntity  Entity => EntityBinder != null ? EntityBinder.Entity : null;

		private void Awake()
		{
			if (!EntityBinder)
			{
				EntityBinder = GetComponent<EntityBinder>();
			}
		}
	}
}