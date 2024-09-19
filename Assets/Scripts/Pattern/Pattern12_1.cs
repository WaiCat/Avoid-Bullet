using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern12_1 : MonoBehaviour
{
    public GameObject Bullet4;
    public GameObject Bullet5;
    public GameObject Bullet6;
    public GameObject Bullet7;
    public GameObject Bullet8;

    public Transform pos;
    private int k = 0;
    public float MoveSpeed;
    private Vector3 Pos;
    public float BulletTerm = 1;
    private float CheckTerm;

    void Update()
    {
        Pos = this.gameObject.transform.position;
        Bullet();
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
        if (Pos.x >= 5 && k == 0)
        {
            MoveSpeed = MoveSpeed * -1f;
            k++;
        }
        if (Pos.x <= -5 && k == 1)
        {
            MoveSpeed = MoveSpeed * -1f;
            k++;
        }
    }
    private void Bullet()
    {
        CheckTerm -= 5f * Time.deltaTime;
        if (CheckTerm <= 0)
        {
            Instantiate(Bullet8, pos.position, transform.rotation);
            Instantiate(Bullet7, pos.position, transform.rotation);
            Instantiate(Bullet6, pos.position, transform.rotation);
            Instantiate(Bullet5, pos.position, transform.rotation);
            Instantiate(Bullet4, pos.position, transform.rotation);
            CheckTerm = BulletTerm;
        }
    }
}
