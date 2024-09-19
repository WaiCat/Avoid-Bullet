using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern9_1 : MonoBehaviour
{
    public Transform pos;

    public GameObject Bullet;
    private float ro = 10f;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            Instantiate(Bullet, pos.position, transform.rotation);
            transform.Rotate(0, 0, ro);
        }
    }
}
