using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }



    }
}
