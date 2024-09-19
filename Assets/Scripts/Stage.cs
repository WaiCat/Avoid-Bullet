using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stage : MonoBehaviour
{
    float currentstage;
    public SetP setp;
    public TextMeshProUGUI txt_stage;
    // Update is called once per frame
    void Update()
    {
        currentstage = setp.Stage;
        if (currentstage == 21)
        {
            txt_stage.text = "End";
        }
        else
            txt_stage.text = string.Format("{0:00}", currentstage);
    }
}
