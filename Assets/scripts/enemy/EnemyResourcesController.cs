using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResourcesController : Characters
{
    [SerializeField] private GameObject NpcPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        if(hp < 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider objCollider)
    {
        if(objCollider.tag == "Beam")
        {
            hp -= 0.5f;
            Destroy(objCollider.gameObject);
        }
        if(objCollider.tag == "Bullet")
        {
            hp -= 2f;
            Destroy(objCollider.gameObject);
        }
        if(objCollider.tag == "ShotGunBullet")
        {
            hp -= 5f;
            Destroy(objCollider.gameObject);
        }
    }

    public void IsDied()
    {
        if(hp >= 0)
        {
            //Actions.AddScore("Npc");
            SpawnEnemy.currentCount--;
            Destroy(gameObject);
            //Invoke("Destroy", 2f);
        }
    }

    void OnDestroy()
    {
        Actions.AddScore("Npc");
    }
}
