//日本語コメント可
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponButton : ObjectToUISerectBase
{
    [SerializeField]
    WeaponType weaponType = WeaponType.NONE;

    protected override void BehaviourOfObject()
    {
        
    }

    protected override void NonSelectionBehavior()
    {
        
    }

    protected override void SelectionBehavior()
    {
        
    }
}
