using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timerStart = 0;

    public TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        Fin.Finish = false;

        timerText.text = timerStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (!Fin.Finish)
        {
            timerStart += Time.deltaTime;

            timerText.text = timerStart.ToString("F2");
        }
    }
}
