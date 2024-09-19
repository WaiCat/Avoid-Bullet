using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern7_1 : MonoBehaviour
{
    public Transform pos;

    public GameObject Bullet;
    private float ro = 8f;

    void Start()
    {
        for (int i = 0; i < 23; i++)
        {
            Instantiate(Bullet, pos.position, transform.rotation);
            transform.Rotate(0, 0, ro);
        }
    }
}
