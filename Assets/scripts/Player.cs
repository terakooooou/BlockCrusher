using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float speed = 1.0f;

    void Start()
    {
        
    }


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
