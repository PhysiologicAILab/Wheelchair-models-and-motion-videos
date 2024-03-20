using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public Transform chair;
    public string[] people;
    // Start is called before the first frame update
    void Start()
    {
        people = new string[] {"person", "person1", "person2"};
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (string name in people)
        {
            if (collision.gameObject.name == name)
            {
                Debug.Log("hey");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
