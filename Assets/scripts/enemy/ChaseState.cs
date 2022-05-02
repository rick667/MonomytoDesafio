using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : BaseState
{
    [SerializeField] EnemyMovement _moveSet;

    public ChaseState(){}

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

        if(_moveSet.agent.isStopped == true)
        {
            owner.ChangeState(new ShottingState());
        }
        if(_moveSet.distance > 10)
        {
            owner.ChangeState(new AwarenessState());
        }
    }
}
