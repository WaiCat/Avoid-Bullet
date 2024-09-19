using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern15 : MonoBehaviour
{
    public Transform pos;
    public GameObject[] B = new GameObject [10];
    public float ro = 0;
    public float rp = 0.01f;
    public float BulletTerm;
    private float CheckTerm;

    void Update()
    {
        CheckTerm -= 5f * Time.deltaTime;
        if (CheckTerm <= 0)
        {
                for (int i = 0; i < 10; i++)
            {
                Instantiate(B[i], pos.position, transform.rotation);
            }
            CheckTerm = BulletTerm;
        }
        transform.Rotate(0, 0, ro);
        ro += rp;
    }
}
