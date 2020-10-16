using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StopGame : MonoBehaviour
{
    public string targetObjetName;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;  
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == targetObjetName) {
            Time.timeScale = 0;
        }
    }
}
