using System;
using UnityEngine;

namespace Patterns.Decorator
{
	[Serializable]
	[CreateAssetMenu(fileName = "ItemAttribute", menuName = "Patterns/Decorator/Attribute/Inventory")]
	public class Inventory : ItemAttribute
	{

		public int stackLimit = 64;

		public string elementType = "Elemental Type";
	}
}
