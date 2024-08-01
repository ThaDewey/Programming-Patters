using UnityEngine;

public class WeaponTest : MonoBehaviour
{
    public WeaponWithDecorators weaponWithDecorators;

    void Start()
    {
        weaponWithDecorators.Attack();
    }
}