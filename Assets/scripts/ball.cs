using System.Security.Cryptography;
using UnityEngine;

public class ball : MonoBehaviour

{

    public float speed = 1.0f;
    private Rigidbody myRigid;
    public GameManager myManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        myManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }
    }
}
