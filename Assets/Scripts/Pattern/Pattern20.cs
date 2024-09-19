
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern20 : MonoBehaviour
{
    public GameObject Bullet1;
    public GameObject Bullet2;
    public GameObject Bullet3;
    private Vector2 Pos1;
    private Vector2 Pos2;
    private Vector2 Pos3;
    private float y = 6;
    private float x;


    public float BulletTerm = 1;
    private float CheckTerm;
    void Update()
    {
        CheckTerm -= 5f * Time.deltaTime;
            if (CheckTerm <= 0)
            {
                x = Random.Range(5f, -5f);
                Pos1 = new Vector2(x, y);
                Instantiate(Bullet1, Pos1, transform.rotation);
                x = Random.Range(5f, -5f);
                Pos2 = new Vector2(x, y);
                Instantiate(Bullet2, Pos2, transform.rotation);
                x = Random.Range(5f, -5f);
                Pos3 = new Vector2(x, y);
                Instantiate(Bullet3, Pos3, transform.rotation);
                CheckTerm = BulletTerm;
            }
    }
}
