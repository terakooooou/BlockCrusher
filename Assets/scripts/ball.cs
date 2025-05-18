using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody myRigid;
    public GameManager myManager;

    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        myManager = FindFirstObjectByType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
            myManager.GameOver();
        }
    }

    public void StopBall()
    {
        if (myRigid != null)
        {
            myRigid.linearVelocity = Vector3.zero;
            myRigid.angularVelocity = Vector3.zero;
            myRigid.isKinematic = true; 
        }
    }
}
