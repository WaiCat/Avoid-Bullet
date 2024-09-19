using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern3 : MonoBehaviour
{
    public GameObject BulletL;
    public GameObject BulletR;
    void Start()
    {
        float x = -6.5f;
        float y = -5.5f;
        for (int i = 0; i < 14; i++)
        {
            Instantiate(BulletL, new Vector2(x, y), transform.rotation);
            x -= 0.8f;
            y += 0.8f;
        }
        x = 6.5f;
        y = -5.1f;
        for (int i = 0; i < 13; i++)
        {
            Instantiate(BulletR, new Vector2(x, y), transform.rotation);
            x += 0.8f;
            y += 0.8f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
