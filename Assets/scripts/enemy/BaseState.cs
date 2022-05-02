using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    public EnemyAIController owner;

    public virtual void PrepareState(){}

    public virtual void UpdateState(){}

    public virtual void DestroyState(){}

}
