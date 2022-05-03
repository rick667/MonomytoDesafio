using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class Manager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    // Start is called before the first frame update

public static Manager Instancia {get; private set;}
    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
    }
    public override void OnJoinedRoom()
    {
    }
    public UnityEvent GameStartfn;
    public void GameStart()
    {
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);
        PhotonNetwork.LoadLevel(1);
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);

    }
}