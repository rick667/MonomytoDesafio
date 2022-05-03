using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class Characters : MonoBehaviourPunCallbacks
{
    public float hp = 10;
    public float spd = 5;

    public void Morrer(Object obj)
    {
        GameObject.Destroy(obj);
    }

}
