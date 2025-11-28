using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Photon.Pun;

public class Player : MonoBehaviourPunCallbacks
{

    [SerializeField] float moveforce;
    [SerializeField] float jumpforce;
    [SerializeField] float rotationSpeed;

    [SerializeField] AudioSource jumpSound;
    [SerializeField] AudioSource landSound;

    Rigidbody rb;
    Vector3 axis;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (photonView.IsMine)
        {
            tag = "Player";
            enabled = true;
        }

        else
        {
            tag = "Untagged";
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        bool jump = Input.GetButtonDown("Jump");
#else
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");
        bool jump = CrossPlatformInputManager.GetButtonDown("Jump");
#endif
        axis = new Vector3(x, 0.0f, y);

        Vector3 center = transform.position + Vector3.up * 0.2f;

        float radius = 0.25f;

        LayerMask layer = LayerMask.GetMask("Default");

        bool isGround = Physics.CheckSphere(center, radius, layer);

        if (isGround && jump)
        {
            Vector3 vj = new Vector3(0.0f, jumpforce, 0.0f);
            rb.AddForce(vj, ForceMode.Impulse);
            photonView.RPC("OnJump", RpcTarget.All);
        }

        if (axis.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(axis, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }

        if (transform.position.y<-15.0f)
        {
            // Reset the player position if it falls below a certain height
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(axis * moveforce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject smoke = Instantiate((GameObject)Resources.Load("Smoke"), transform.position, Quaternion.identity);

        Destroy(smoke, 2.0f);

        if (photonView.IsMine && collision.gameObject.tag == "Finish")
        {
            GameObject.Find("GameManager").GetComponent<Gamemanager>().Win();
        }

        landSound.Play();
    }

    [PunRPC]
    public void OnJump()
    {
        jumpSound.Play();
    }
}
