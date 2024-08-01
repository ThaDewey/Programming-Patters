using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class Client : MonoBehaviour
    {
        public List<Item> items;

        private void Start()
        {
            foreach (var item in items)
            {
                Debug.Log(item.displayName + " Base Value: " + item.marketValue.ToString());

                int totalValue = item.marketValue; // Assuming you might want to calculate total value with enchantments later
                Debug.Log(item.displayName + " Total Value: " + totalValue.ToString());

                string attributes = item.GetAttributes();
                Debug.Log(item.displayName + " Attributes: " + attributes);
            }
        }
    }
}
