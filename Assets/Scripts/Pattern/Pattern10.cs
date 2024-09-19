using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern10 : MonoBehaviour
{
    public GameObject Bullet;
    public Transform pos;
    public float ro = 1f;
    public float BulletTerm;
    private float CheckTerm;

    private float k = 0;

    void Update()
    {
        CheckTerm -= 5f * Time.deltaTime;
        if (k < 3)
        {
            if (CheckTerm <= 0)
            {
                for (int i = 0; i < 60; i++)
                {
                    Instantiate(Bullet, pos.position, transform.rotation);
                    CheckTerm = BulletTerm;
                    transform.Rotate(0, 0, ro);
                }
                k++;
                transform.Rotate(0, 0, 5);
            }
        }
    }
}
