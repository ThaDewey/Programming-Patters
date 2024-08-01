using UnityEngine;

namespace Patterns.Decorator
{
	[CreateAssetMenu(fileName = "Magic", menuName = "Patterns/Decorator/Magic")]
	public class Magic : Enchantment
	{
		private void OnEnable()
		{
			_displayName = "Magic";
			_marketValue = 30;
		}

		public override string displayName => base.displayName;
		public override int marketValue => base.marketValue;
	}
}
