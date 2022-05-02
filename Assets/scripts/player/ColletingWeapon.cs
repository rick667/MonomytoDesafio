using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColletingWeapon : MonoBehaviour
{
    public GameObject pistol;
    public GameObject shotGun;
    public GameObject BeamGun;
    public GunController gunController;


    void Start()
    {
    }
 
    void OnTriggerEnter(Collider objCollider)
    {
        if(objCollider.tag == "PistolCol")
        {
            if(gameObject.transform.childCount > 1)
            {
                Destroy(gunController.myGun);
            }
            Actions.ThisEquippedGun(pistol, gameObject);
            gunController.myGun.transform.rotation = transform.rotation;
            Actions.WeaponHasChange("Pistol");
            Destroy(objCollider.gameObject);


        }
        if(objCollider.tag == "ShotGunCol")
        {
            if(gameObject.transform.childCount > 1)
            {
                Destroy(gunController.myGun);
            }            
            Actions.ThisEquippedGun(shotGun, gameObject);
            gunController.myGun.transform.rotation = transform.rotation;
            Actions.WeaponHasChange("ShotGun");
            Destroy(objCollider.gameObject);

        }
        if(objCollider.tag == "BeamGunCol")
        {
            if(gameObject.transform.childCount > 1)
            {
                Destroy(gunController.myGun);
            }
            Actions.ThisEquippedGun(BeamGun, gameObject);
            gunController.myGun.transform.rotation = transform.rotation;
            Actions.WeaponHasChange("BeamGun");
            Destroy(objCollider.gameObject);

        }
    }
}
