using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern18 : MonoBehaviour
{
    public GameObject[] B = new GameObject[8];
    public Transform pos;
    public float ro = 0.01f;
    public float BulletTerm;
    private float CheckTerm;
    public SetP setps;

    public float MoveSpeed;
    private float delay = 15f; 
    void Update()
    {
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0, Space.World);
        CheckTerm -= 5f * Time.deltaTime;
        if (CheckTerm <= 0)
        {
            for (int i = 0; i < 8; i++)
            {
                Instantiate(B[i], pos.position, transform.rotation);
                CheckTerm = BulletTerm;
            }
        }
        transform.Rotate(0, 0, ro);
    }
}
