using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern13 : MonoBehaviour
{
    public float ro = 0;
    public float rp = 1f;
    public GameObject Bullet6;
    public Transform pos;
    void Update()
    {
        Instantiate(Bullet6, pos.position, transform.rotation);
        transform.Rotate(0, 0, ro);
        ro += rp;
    }
}
