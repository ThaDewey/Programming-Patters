using System;
using UnityEngine;

namespace Patterns.Decorator
{
	[Serializable]
	[CreateAssetMenu(fileName = "ItemAttribute", menuName = "Patterns/Decorator/Attribute/ElementalType")]
	public class Elemental : ItemAttribute
	{



		public string elementType = "Elemental Type";
	}
}
