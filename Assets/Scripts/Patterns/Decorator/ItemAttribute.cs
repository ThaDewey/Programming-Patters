using System;
using UnityEngine;

namespace Patterns.Decorator
{
	[Serializable]
	[CreateAssetMenu(fileName = "ItemAttribute", menuName = "Patterns/Decorator/Attribute")]
	public abstract class ItemAttribute : ScriptableObject, IAttribute
	{
		public IAttribute attribute;
		[SerializeField] protected string _displayName;
		public string displayName => _displayName;
	}
}
