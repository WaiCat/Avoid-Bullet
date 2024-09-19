using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern5 : MonoBehaviour
{
    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    public GameObject Bullet4;
    void Start()
    {
        float x = 6.5f;
        float y = 5.5f;
        float x1 = -6.5f;
        float y1 = -5.5f;
        Instantiate(Bullet1, new Vector2(x, y), transform.rotation);
        for (int i = 0; i < 16; i++)
        {
            x -= 0.8f;
            Instantiate(Bullet1, new Vector2(x, y), transform.rotation);
        }
        x = 6.5f;

        Instantiate(Bullet2, new Vector2(x, y), transform.rotation);
        for (int i = 0; i < 14; i++)
        {
            y -= 0.8f;
            Instantiate(Bullet2, new Vector2(x, y), transform.rotation);
        }

        Instantiate(Bullet3, new Vector2(x1, y1), transform.rotation);
        for (int i = 0; i < 14; i++)
        {
            y1 += 0.8f;
            Instantiate(Bullet3, new Vector2(x1, y1), transform.rotation);
        }

        y1 = -5.5f;
        Instantiate(Bullet4, new Vector2(x1, y1), transform.rotation);
        for (int i = 0; i < 16; i++)
        {
            x1 += 0.8f;
            Instantiate(Bullet4, new Vector2(x1, y1), transform.rotation);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
