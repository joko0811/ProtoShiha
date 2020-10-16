using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Hide : MonoBehaviour
{
    public string targetObjectName;
    public string hide0bjectName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName) {
            GameObject hideObject = GameObject.Find(hide0bjectName);
            hideObject.SetActive(false);
        }    
    }
}
