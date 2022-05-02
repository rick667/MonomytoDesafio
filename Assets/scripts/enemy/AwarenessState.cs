using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwarenessState : BaseState
{
    public AwarenessState(){}
   [SerializeField] EnemyMovement _moveSet;
    public override void PrepareState()
    {
        base.PrepareState();
        _moveSet = GetComponent<EnemyMovement>();
    }

    public override void UpdateState()
    {
        base.UpdateState();
        _moveSet.Movement();

        _moveSet.MoveSet();

        if(_moveSet.distance < 10)
        {
            owner.ChangeState(new ChaseState());
        }
    }
}
