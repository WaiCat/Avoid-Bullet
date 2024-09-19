using UnityEngine;

public class Pattern11 : MonoBehaviour
{
    public GameObject[] B = new GameObject[8];
    public Transform pos;
    public float ro = 0.01f;
    public float BulletTerm;
    private float CheckTerm;

    void Update()
    {
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
