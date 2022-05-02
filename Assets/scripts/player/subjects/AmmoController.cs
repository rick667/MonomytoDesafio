using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoController : MonoBehaviour
{
    public PlayerMovementController direction;
    private RaycastHit hit;
    private Vector3 directionToGo;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            directionToGo = hit.point - transform.position;
            directionToGo.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(directionToGo);
            _rb.MoveRotation(newRotation);
        } 
    }

    void Update()
    {
        _rb.velocity = transform.forward * 15;
    }
}
