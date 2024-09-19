using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern16 : MonoBehaviour
{
    public float ro = 0;
    public float rp = 1f;
    public GameObject Bullet6;
    public GameObject Bullet12;
    public Transform pos;

    // Update is called once per frame
    void Update()
    {
        Instantiate(Bullet6, pos.position, transform.rotation);
        Instantiate(Bullet12, pos.position, transform.rotation);
        transform.Rotate(0, 0, ro);
        ro+=rp;
    }
}
