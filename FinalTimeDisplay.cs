using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FinalTimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI finaltimerUI;
    public void FinalTimer_1(int Min, int Sec)
    {
        finaltimerUI.text = Min + "." + Sec;
    }
}
