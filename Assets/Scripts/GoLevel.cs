using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoLevel : MonoBehaviour
{
    public TMP_Text GoLevelText;

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();

        Fin.CountLevel++;

        GoLevelText.text = Fin.CountLevel + "/7";
    }
}
