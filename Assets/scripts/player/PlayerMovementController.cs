using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovementController : Characters
{
    // Start is called before the first frame update
    [SerializeField]private Rigidbody _rb;
    [SerializeField]private GunController _gun;
    private RaycastHit hit;
    public Vector3 PlayerTomouse;
    public Vector3 newMovement;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
        _gun = GetComponent<GunController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        if(_gun.fireDelay < (Time.time - _gun.LastFire))
        {
            Actions.FireRate(GameGenericsProperties.gameStatus, _gun.gunBullet.gameObject, gameObject);
        }
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            PlayerTomouse = hit.point - transform.position;
            PlayerTomouse.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(PlayerTomouse);
            _rb.MoveRotation(newRotation);
        } 
    }
    public void Movement()
    {

        newMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        newMovement = newMovement.normalized * spd * Time.deltaTime;
        _rb.MovePosition(transform.position + newMovement);
    }    


}
