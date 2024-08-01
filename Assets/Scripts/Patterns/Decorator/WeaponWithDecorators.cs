using UnityEngine;

public class WeaponWithDecorators : MonoBehaviour, IWeapon
{
    public IWeapon baseWeapon;
    public WeaponDecoratorSO[] decorators;

    private void Start()
    {
        baseWeapon = GetComponent<IWeapon>();
    }

    public void Attack()
    {
        // baseWeapon.Attack();
        foreach (var decorator in decorators)
        {
            decorator.OnAttack();
        }
    }
}
