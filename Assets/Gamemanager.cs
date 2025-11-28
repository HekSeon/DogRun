using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UIElements;
using System.Security.Principal;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject wintext;
    [SerializeField] GameObject losetext;
    bool finish = false;

    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("CreatePlayer", 0.2f);
    }

    private void CreatePlayer()
    {
        Vector3 position = new Vector3(Random.Range(-3f, 3f), 0.5f, 0.0f);

        player = PhotonNetwork.Instantiate("Player", position, Quaternion.identity);
    }

    void OnGUI()
    {
       GUI.skin.label.fontSize = 18;
       GUI.color = Color.black;
        GUILayout.Label("State : " + PhotonNetwork.NetworkClientState.ToString());
        GUILayout.Label("Ping : " + PhotonNetwork.GetPing().ToString() + "ms");

        if (PhotonNetwork.InRoom)
        {
            GUILayout.Label("RoomName : " + PhotonNetwork.CurrentRoom.Name);
            GUILayout.Label("PlayerCout : " + PhotonNetwork.CurrentRoom.PlayerCount.ToString());
            GUILayout.Label("MasterClient : " + PhotonNetwork.IsMasterClient.ToString());
        }
    }

    public void Win()
    {
        if (finish) return;
        finish = true;
        wintext.SetActive(true);
        photonView.RPC("LOSE",RpcTarget.Others);

        Invoke("Finish", 3.0f);
    }

    [PunRPC]
    public void LOSE()
    {
        finish = true;
        losetext.SetActive(true);
    }

    public void Finish()
    {
        photonView.RPC("ToTitle", RpcTarget.All);
    }

    [PunRPC]
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
