using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody _rb;
    public NavMeshAgent agent;
    [SerializeField]private GameObject _destination;
    public Vector3 newMovement;
    public float spd = 5;
    public Vector3 direction;
    public float distance;
    public Text text;
    public EnemyResourcesController hp;
    void Start()
    {
        _destination = GameObject.FindWithTag("Player");
        _rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();     
        hp = GetComponent<EnemyResourcesController>();
    }
    void Update()
    {
        direction = transform.position - _destination.transform.position;
        distance = direction.magnitude;       
    }

    public void Movement()
    {
        agent.SetDestination(_destination.transform.position);
    } 
    public void MoveSet()
    {
        if(hp.hp > 0 )
        {
            if(distance < 8)
            {
                agent.isStopped = true;
            }else if(distance > 7 && distance < 16)
            {
                agent.speed = 4;
            }else if(distance > 15)
            {
                agent.isStopped = false;
                agent.speed = 2;
            }
        
        }else
        {
            agent.isStopped = true;
            hp.IsDied();
        }
    }
}
