using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GunController : MonoBehaviour
{
    [SerializeField]private string _gun = "Pistol";
    [SerializeField]private int _maxAmmoOfGun = 10;
    public float fireDelay = 1;
    public float gunDamage = 2;
    [SerializeField]private GameObject _bullet;
    [SerializeField]private GameObject _beam;
    [SerializeField]private GameObject _shotGunBullet; 
    public GameObject gunBullet;

    private int _currentAmmo;
    public float LastFire = 0;
    public GameObject equippedGun;
    public GameObject myGun;

    void OnEnable()
    {
        Actions.WeaponHasChange += SetGun;
        Actions.WeaponHasChange += ChangeWeapons;
        Actions.FireRate += Fire;
        Actions.ThisEquippedGun += SetEquippedGun;
        Actions.ItsRealoaded += Reload;
;

    }
    void OnDisable()
    {
        Actions.WeaponHasChange -= ChangeWeapons;
        Actions.WeaponHasChange -= SetGun;
        Actions.FireRate -= Fire;
        Actions.ThisEquippedGun -= SetEquippedGun;
        Actions.ItsRealoaded -= Reload;
;

    }
    void update()
    {

    }
    void ChangeWeapons(string gun)
    {
        switch(_gun)
        {
            case "Pistol":
                _maxAmmoOfGun = 10;
                _currentAmmo = 10;
                fireDelay = 1;
                gunBullet = _bullet;
                gunDamage = 2;
                break;
            case "ShotGun":
                _maxAmmoOfGun = 4;
                _currentAmmo = 4;
                fireDelay = 2;
                gunBullet = _shotGunBullet;
                gunDamage = 5;
                break;
            
            case "BeamGun":
                _maxAmmoOfGun = 100;
                _currentAmmo = 100;
                fireDelay = 0.1f;
                gunBullet = _beam;
                gunDamage = 0.5f;
                break;
        }
    }

    public void Fire(int gameStatus, GameObject ammoPrefab, GameObject spot)
    {
        if(gameStatus == 1)
        {
            if(Input.GetMouseButton(0))
            {
                if(_currentAmmo > 0)
                {
                    GameObject individualBullet = GameObject.Instantiate(ammoPrefab,new Vector3(spot.transform.position.x, spot.transform.position.y, spot.transform.position.z), Quaternion.identity); 
                    LastFire = Time.time;    
                    _currentAmmo --;
                }
            }
    
        }
        
    }
    public void SetEquippedGun(GameObject gun, GameObject spot)
    {
        equippedGun = gun;
        myGun = GameObject.Instantiate(gun, new Vector3(spot.transform.position.x +0.55f, spot.transform.position.y + 0.05f, spot.transform.position.z +0.3f), Quaternion.identity);
        myGun.transform.parent = spot.transform;
    }

    public void Reload()
    {
        _currentAmmo = _maxAmmoOfGun;
    }
    public void SetGun(string gun)
    {
        _gun = gun;
    }

}
