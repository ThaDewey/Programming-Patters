using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
	[CreateAssetMenu(fileName = "Item", menuName = "Patterns/Decorator/Item")]
	public class Item : ScriptableObject, IItem
	{
		public List<Enchantment> enchantments;
		public List<ItemAttribute> attributes;
		public string _displayName;
		public int _marketValue;

		public string displayName => _displayName;
		public int marketValue => _marketValue;

		public int GetTotalValue()
		{
			int totalValue = _marketValue;
			IItem current = this;

			foreach (var enchantment in enchantments)
			{
				enchantment.SetBaseItem(current);
				current = enchantment;
			}

			return current.marketValue;
		}
		public string GetAttributes()
		{
			string result = "";
			foreach (var attribute in attributes)
			{
				result += attribute.displayName + " ";
				if (attribute is Elemental elemental)
				{
					result += elemental.elementType + " ";
				}
			}
			return result.Trim();
		}


	}
}
