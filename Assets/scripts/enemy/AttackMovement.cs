using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AttackMovement : MonoBehaviour
{
    private RaycastHit hit;
    private Vector3 directionToGo;
    private Rigidbody _rb;
    public GameObject player;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
        directionToGo = player.transform.position - transform.position;
        directionToGo.y = 0;  

    }

    void Update()
    {
      
        transform.position += directionToGo.normalized / 5;
    }  

}
