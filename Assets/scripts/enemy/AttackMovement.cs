using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AttackMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody _rb;
    [SerializeField]private GameObject _destination;
    public Vector3 direction;
    public float distance;

    void Start()
    {
        _destination = GameObject.FindWithTag("Player");
        _rb = GetComponent<Rigidbody>();  
        direction = transform.position - _destination.transform.position;
        distance = direction.magnitude; 
                     
    }

    public void Movement()
    {
        _rb.velocity = transform.forward * 15;
    }     

}
