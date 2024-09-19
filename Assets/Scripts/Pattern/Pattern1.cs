 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pattern1 : MonoBehaviour
{
    public SetP setps;
    public GameObject Bullet;
    public float delay;
    public int i =1 ;

    void Update()
    {

        if (delay < 0f &&i==1)
        {
            float x = -6.9f;
            float y = 5.5f;
            for (int i = 0; i < 13; i++)
            {
                x += 1f;
                y += 0.4f;
                Instantiate(Bullet, new Vector2(x, y), transform.rotation);
            }
            x += 0.5f;
            for (int i = 0; i < 13; i++)
            {
                x -= 1f;
                y += 0.4f;
                Instantiate(Bullet, new Vector2(x, y), transform.rotation);
            }
            setps.endp[0] = false;
            i = 0;
        }
        delay -= Time.deltaTime;
    }
}
