using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonWeapon : Weapon
{
    [SerializeField] private int poisonDamage = 2;
    public override void ApplyEffect(Character character)
    {
        character.TakeDamage(poisonDamage);
        Debug.Log(character.name + " take " + poisonDamage );

    }

    

}
