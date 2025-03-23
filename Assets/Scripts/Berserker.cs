using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int aggressionGain = 10;
    public override int Attack()
    {
        aggresion += aggressionGain;
        return ActiveWeapon.GetDamage() + aggresion / 10;
    }
}


