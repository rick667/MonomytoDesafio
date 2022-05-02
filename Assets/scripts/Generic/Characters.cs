using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public float hp = 10;
    public float spd = 5;

    public void Morrer(Object obj)
    {
        GameObject.Destroy(obj);
    }

}
