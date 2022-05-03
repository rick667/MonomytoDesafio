using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShottingState : BaseState
{
    [SerializeField] private EnemyMovement _resources;
    public float fireDelay = 2f;
    public float lastFire;

    public ShottingState()
    {
    }

    public override void PrepareState()
    {
        base.PrepareState();
    }

    public override void UpdateState()
    {
        base.UpdateState();
        if(_resources.fireDelay < (Time.time - _resources.lastFire))
        {
            Actions.NpcAttack(_resources.attack, gameObject);
        }        

    }

}
