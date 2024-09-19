using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public float time;
    void Start()
    {
        time = 10;
        Invoke("DestroyBullet", time);
    }

    void Update()
    {
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}