using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject myBody;
    public GameObject myCamera;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speed);
            myBody.transform.Translate(0, 0, speed);
            myCamera.transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed);
            myBody.transform.Translate(0, 0, -speed);
            myCamera.transform.Translate(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
            myBody.transform.Translate(-speed, 0, 0);
            myCamera.transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
            myBody.transform.Translate(speed, 0, 0);
            myCamera.transform.Translate(speed, 0, 0);
        }
    }
}
