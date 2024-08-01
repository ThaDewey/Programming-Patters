using System;
using UnityEngine;

namespace Patterns.Decorator
{
    [Serializable]
    [CreateAssetMenu(fileName = "Enchantment", menuName = "Patterns/Decorator/Enchantment")]
    public class Enchantment : ScriptableObject, IItem
    {
        protected IItem _item;

        public string _displayName;
        public int _marketValue;

        public virtual string displayName => _item != null ? $"{_item.displayName}, {_displayName}" : _displayName;
        public virtual int marketValue => _item != null ? _item.marketValue + _marketValue : _marketValue;

        public void SetBaseItem(IItem baseItem)
        {
            _item = baseItem;
        }
    }
}
