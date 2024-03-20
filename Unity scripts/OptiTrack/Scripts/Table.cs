using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;

    void Start()
    {
       transform.position -= new Vector3(0f, 50f, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
