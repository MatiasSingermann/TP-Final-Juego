using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public paintPlatform scriptPaintPlatform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision playerPlatform)
    {
        Debug.Log("toca");
        if (playerPlatform.gameObject.name == "platform")
        {
            paintPlatform pp = playerPlatform.gameObject.GetComponent<paintPlatform>();
            if (pp.numberMaterial == 1 || pp.numberMaterial == 2 || pp.numberMaterial == 3 || pp.numberMaterial == 4)
            {
                Debug.Log("no toca");
                pp.myCollider.enabled = false;
            }
            if (GetComponent<Renderer>().material == pp.White)
            {
                Debug.Log("toca x2");
                pp.myCollider.enabled = true;
            }
        }
        else
        {
            //scriptPaintPlatform.myCollider.enabled = true;
        }
    }
}
