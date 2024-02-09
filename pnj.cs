using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pnj : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 3f;
    public string name = "villagor";
    void Start()
    {
    health+=level;
    print (health);
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 bot = transform.position;
    bot.z += speed * Time.deltaTime;
    transform.position = bot;
    }
}
