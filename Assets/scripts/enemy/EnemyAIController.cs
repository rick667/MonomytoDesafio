using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIController : MonoBehaviour
{
    public BaseState currentState;
    public AwarenessState inicial;

    private void Start()
    {
    }

    private void Update()
    {

            if (currentState != null)
            {
                currentState.UpdateState();
            }
            else
            {
                ChangeState(inicial);
            }

    }
    public void ChangeState(BaseState newState)
    {
        if (currentState != null)
        {
            currentState.DestroyState();
        }
        currentState = newState;

        if (currentState != null)
        {
            currentState.owner = this;
            currentState.PrepareState();
        }
    }
}
