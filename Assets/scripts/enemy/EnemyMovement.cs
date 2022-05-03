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
    public GameObject attack;
    public Vector3 newMovement;
    public float spd = 5;
    public Vector3 direction;
    public float distance;
    public Text text;
    public EnemyResourcesController hp;
    public float fireDelay = 2f;
    public float lastFire;   
    private RaycastHit hit;
    public Vector3 PlayerTomouse;     
    void Start()
    {
        _destination = GameObject.FindWithTag("Player");
        _rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();     
        hp = GetComponent<EnemyResourcesController>();
        Actions.NpcAttack += Attack;
    }
    void OnDisable()
    {
        Actions.NpcAttack -= Attack;
    }
    void Update()
    {
        direction = transform.position - _destination.transform.position;
        distance = direction.magnitude;
        PlayerTomouse = _destination.transform.position - transform.position;
        PlayerTomouse.y = 0;
        Quaternion newRotation = Quaternion.LookRotation(PlayerTomouse);
        _rb.MoveRotation(newRotation);
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
                if(fireDelay < (Time.time - lastFire))
                {
                    Attack(attack, gameObject);
                }         
                agent.speed = 2;

            //agent.isStopped = true;
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
    public void Attack(GameObject attack, GameObject spot)
    {
        GameObject individualAttack = GameObject.Instantiate(attack,new Vector3(spot.transform.position.x, spot.transform.position.y, spot.transform.position.z), Quaternion.identity); 
        lastFire = Time.time;
        individualAttack.tag = "NpcAtk";
    
    }
}
