using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetP : MonoBehaviour
{
    public GameObject[] P = new GameObject[21];
    public int Stage;
    public bool[] endp = new bool[21];
    AudioSource audio;
    public GameObject End;
    public GameObject Death;

    public float d;


    void Start()
    {
        d = 0;
        Stage = 1;
        endp[0] = true;
        for (int i = 1; i < 21; i++)
        {
            endp[i] = false;
        }
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void Update()
    {
        if (d >= 1 && d <= 10)
        {
            P[0].SetActive(true);
        }
        else
        {            
            P[0].SetActive(false);
        }
        if (d >= 13 && d <= 20)
        {
            if (Stage == 1)
                Stage++;
            P[1].SetActive(true);
        }
        else
        {
            P[1].SetActive(false);
        }
        if (d >= 23 && d <= 31)
        {
            if (Stage == 2)
                Stage++;
            P[2].SetActive(true);
        }
        else
        {
            P[2].SetActive(false);
        }
        if (d >= 34 && d <= 39)
        {
            if (Stage == 3)
                Stage++;
            P[3].SetActive(true);
        }
        else
        {
            P[3].SetActive(false);
        }
        if (d >= 42 && d <= 47)
        {
            if (Stage == 4)
                Stage++;
            P[4].SetActive(true);
        }
        else
        {
            P[4].SetActive(false);
        }
        if (d >= 50 && d <= 58)
        {
            if (Stage == 5)
                Stage++;
            P[5].SetActive(true);
        }
        else
        {
            P[5].SetActive(false);
        }
        if (d >= 61 && d <= 65)
        {
            if (Stage == 6)
                Stage++;
            P[6].SetActive(true);
        }
        else
        {
            P[6].SetActive(false);
        }
        if (d >= 68 && d <= 77)
        {
            if (Stage == 7)
                Stage++;
            P[7].SetActive(true);
        }
        else
        {
            P[7].SetActive(false);
        }
        if (d >= 80 && d <= 85)
        {
            if (Stage == 8)
                Stage++;
            P[8].SetActive(true);
        }
        else
        {
            P[8].SetActive(false);
        }
        if (d >= 88 && d <= 104)
        {
            if (Stage == 9)
                Stage++;
            P[9].SetActive(true);
        }
        else
        {
            P[9].SetActive(false);
        }
        if (d >= 107 && d <= 117)
        {
            if (Stage == 10)
                Stage++;
            P[10].SetActive(true);
        }
        else
        {
            P[10].SetActive(false);
        }
        if (d >= 123 && d <= 133)
        {
            if (Stage == 11)
                Stage++;
            P[11].SetActive(true);
        }
        else
        {
            P[11].SetActive(false);
        }
        if (d >= 139 && d <= 149)
        {
            if (Stage == 12)
                Stage++;
            P[12].SetActive(true);
        }
        else
        {
            P[12].SetActive(false);
        }
        if (d >= 155 && d <= 165)
        {
            if (Stage == 13)
                Stage++;
            P[13].SetActive(true);
        }
        else
        {
            P[13].SetActive(false);
        }
        if (d >= 171 && d <= 181)
        {
            if (Stage == 14)
                Stage++;
            P[14].SetActive(true);
        }
        else
        {
            P[14].SetActive(false);
        }
        if (d >= 187 && d <= 197)
        {
            if (Stage == 15)
                Stage++;
            P[15].SetActive(true);
        }
        else
        {
            P[15].SetActive(false);
        }
        if (d >= 203 && d <= 213)
        {
            if (Stage == 16)
                Stage++;
            P[16].SetActive(true);
        }
        else
        {
            P[16].SetActive(false);
        }
        if (d >= 219 && d <= 235)
        {
            if (Stage == 17)
                Stage++;
            P[17].SetActive(true);
        }
        else
        {
            P[17].SetActive(false);
        }
        if (d >= 241 && d <= 251)
        {
            if (Stage == 18)
                Stage++;
            P[18].SetActive(true);
        }
        else
        {
            P[18].SetActive(false);
        }
        if (d >= 257 & d <= 277)
        {
            if (Stage == 19)
                Stage = 20;
            P[19].SetActive(true);
        }
        else
        {
            P[19].SetActive(false);
        }
        if (d>= 281)
        {
            Stage = 21;
            Death.SetActive(false);
            End.SetActive(true);
        }
        d += Time.deltaTime;
    }
}
