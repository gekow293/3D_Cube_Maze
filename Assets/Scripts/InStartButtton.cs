using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InStartButtton : MonoBehaviour
{
    private BallScript BallScript;

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnMouseDown()
    {
        BallScript.Reset();
    }
}
