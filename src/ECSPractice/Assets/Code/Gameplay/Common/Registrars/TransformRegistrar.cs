using Code.Infrastructure.Registrars;

namespace Code.Gameplay.Common.Registrars
{
	public class TransformRegistrar : EntityComponentRegistrar
	{
		public override void RegisterComponents()
		{
			Entity
				.AddTransform(transform);
		}

		public override void UnregisterComponents()
		{
			Entity
				.RemoveTransform();
		}
	}
}