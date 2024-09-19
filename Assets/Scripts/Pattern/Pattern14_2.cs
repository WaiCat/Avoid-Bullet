using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern14_2 : MonoBehaviour
{
    public Transform pos;
    public GameObject[] P = new GameObject[4];
    public float ro = -1;
    public float BulletTerm = 1;
    private float CheckTerm;
    void Update()
    {
        CheckTerm -= 5f * Time.deltaTime;
        if (CheckTerm <= 0)
        {
            for (int i = 0; i < 4; i++)
            {
                Instantiate(P[i], pos.position, transform.rotation);
                CheckTerm = BulletTerm;
            }
        }
        transform.Rotate(0, 0, ro);
    }
}