using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern2 : MonoBehaviour
{
    public GameObject Bullet;
    void Start()
    {
        float x = -6.7f;
        float y = 5.5f;
        for (int i = 0; i < 17; i++)
        {
            x += 0.8f;
            Instantiate(Bullet, new Vector2(x, y), transform.rotation);
        }

        y += 2f;
        x += 0.4f;
        for (int i = 0; i < 17; i++)
        {
            x -= 0.8f;
            Instantiate(Bullet, new Vector2(x, y), transform.rotation);
        }
        y += 2f;
        x -= 0.4f;
        for (int i = 0; i < 17; i++)
        {
            x += 0.8f;
            Instantiate(Bullet, new Vector2(x, y), transform.rotation);
        }
        y += 2f;
        x += 0.4f;
        for (int i = 0; i < 17; i++)
        {
            x -= 0.8f;
            Instantiate(Bullet, new Vector2(x, y), transform.rotation);
        }
        y += 2f;
        x -= 0.4f;
        for (int i = 0; i < 17; i++)
        {
            x += 0.8f;
            Instantiate(Bullet, new Vector2(x, y), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
