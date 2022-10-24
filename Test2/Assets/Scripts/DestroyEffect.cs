using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float timeDel = 1f;
    void Update()
    {
        Invoke("Delete", timeDel);
    }
    
    void Delete()
    {
     Destroy(gameObject);
    }
}

