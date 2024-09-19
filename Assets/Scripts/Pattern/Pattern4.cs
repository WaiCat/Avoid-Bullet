using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern4 : MonoBehaviour
{
    public GameObject BulletU;
    public GameObject BulletD;
    void Start()
    {
        float x = -0.2f;
        float x1 = -0.2f;
        float y = 5.2f;
        Instantiate(BulletU, new Vector2(x, y), transform.rotation);
        for (int i = 0; i < 8; i++)
        {
            x -= 0.8f;
            x1 += 0.8f;
            y += 0.4f;
            Instantiate(BulletU, new Vector2(x1, y), transform.rotation);
            Instantiate(BulletU, new Vector2(x, y), transform.rotation);
        }
        x = 0.2f;
        x1 = 0.2f;
        y = -5.2f;
        Instantiate(BulletD, new Vector2(x1, y), transform.rotation);
        for (int i = 0; i < 8; i++)
        {
            x -= 0.8f;
            x1 += 0.8f;
            y -= 0.4f;
            Instantiate(BulletD, new Vector2(x1, y), transform.rotation);
            Instantiate(BulletD, new Vector2(x, y), transform.rotation);
        }

    }
}
