using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_ChangeAnime : MonoBehaviour
{
    public string goAnime = "";
    public string shrowAnime = "";
    string nowMode = "";
    // Start is called before the first frame update
    void Start()
    {
        nowMode = goAnime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") || Input.GetKey("left"))
        {
            nowMode = goAnime;
        }
        if (Input.GetKeyDown("space")) {
            nowMode = shrowAnime;
        }
    }

    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowMode);
    }
}
