using UnityEngine;
[CreateAssetMenu(menuName = "WeaponDecorators/IceDecorator")]
public class IceDecoratorSO : WeaponDecoratorSO
{
    public override void OnAttack()
    {
        AddIceEffect();
    }

    private void AddIceEffect()
    {
        Debug.Log("Adding ice effect to the attack!");
    }
}
