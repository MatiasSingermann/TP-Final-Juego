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
            if (scriptPaintPlatform.numberMaterial == 1 || scriptPaintPlatform.numberMaterial == 2 || scriptPaintPlatform.numberMaterial == 3 || scriptPaintPlatform.numberMaterial == 4)
            {
                Debug.Log("no toca");
                scriptPaintPlatform.myCollider.enabled = false;
            }
            if (GetComponent<Renderer>().material == scriptPaintPlatform.White)
            {
                Debug.Log("toca x2");
                scriptPaintPlatform.myCollider.enabled = true;
            }
        }
        else
        {
            scriptPaintPlatform.myCollider.enabled = true;
        }
    }
}
