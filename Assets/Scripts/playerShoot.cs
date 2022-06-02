using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject myCamera;
    public GameObject crosshair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, myCamera.transform.forward, out hit))
            {
                Vector3 shotPosition = hit.point;
                float shootDistance = hit.distance;
                string GameObjectShot = hit.collider.gameObject.name;
            }
        }
    }

    void OnCollisionEnter(Collision enemyShot)
    {
        if (enemyShot.gameObject.name == "Cube")
        {
            Debug.Log("messi");
        }
        else if (enemyShot.gameObject.name != "Cube")
        {
            Debug.Log("cristiano");
        }
    }
}
