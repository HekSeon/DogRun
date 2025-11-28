using UnityEngine;
using Photon.Pun;
using UnityStandardAssets.Utility;

public class MoveEnable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            gameObject.GetComponent<AutoMoveAndRotate>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
