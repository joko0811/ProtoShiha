using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foever_MoveH : MonoBehaviour
{
    public float speed = 1;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(speed / 50,0,0);
    }

}
