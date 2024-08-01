using UnityEngine;

[CreateAssetMenu(menuName = "WeaponDecorators/FireDecorator")]
public class FireDecoratorSO : WeaponDecoratorSO
{
    public override void OnAttack()
    {
        AddFireEffect();
    }

    private void AddFireEffect()
    {
        Debug.Log("Adding fire effect to the attack!");
    }
}