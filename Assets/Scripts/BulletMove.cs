using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float XSpeed = 3;
    public float YSpeed = 3;
    public float ro;
    // Update is called once per frame
    void Start()
    {
        transform.Rotate(0, 0, ro);
    }
    void Update()
    {
        transform.Translate(XSpeed * Time.deltaTime, YSpeed * Time.deltaTime, 0);

    }
}
