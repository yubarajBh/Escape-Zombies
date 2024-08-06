using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Update()
    {
        if(transform.position.y<-6f)
        {
            Destroy(gameObject);
        }
    }
}
