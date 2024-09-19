using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Death : MonoBehaviour
{
    float currentdeath;
    public PlayerMove Player;
    public TextMeshProUGUI txt_death;
    // Update is called once per frame
    void Update()
    {
        currentdeath = Player.Death;
        txt_death.text = currentdeath.ToString();
    }
}
