using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class titlemanager : MonoBehaviourPunCallbacks
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PhotonNetwork.IsConnected) PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        bool start = false;

        if (Input.GetMouseButton(0))
        {
            start = true;
        }

        if (Input.touchCount > 0)
        {
            Touch touch =Input.GetTouch(0);
            if (touch.phase==TouchPhase.Began) start = true;
        }

        if (PhotonNetwork.InRoom&&start) photonView.RPC("LoadScene", RpcTarget.All);
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }


    [PunRPC]
    public void LoadScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void OnGUI()
    {
        
        GUI.skin.label.fontSize = 18;

        GUI.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);

        GUILayout.Label("State : " + PhotonNetwork.NetworkClientState.ToString());
        GUILayout.Label("Ping : " + PhotonNetwork.GetPing().ToString() + "ms");

        if (PhotonNetwork.InRoom)
        {
            GUILayout.Label("RoomName : " + PhotonNetwork.CurrentRoom.Name);
            GUILayout.Label("PlayerCout : " + PhotonNetwork.CurrentRoom.PlayerCount.ToString());
            GUILayout.Label("MasterClient : " + PhotonNetwork.IsMasterClient.ToString());
        }

     }
}
