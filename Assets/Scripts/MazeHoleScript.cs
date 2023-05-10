using UnityEngine;
using System.Collections;
using TMPro;
using Assets.Scripts;
using UnityEngine.UI;

public class MazeHoleScript : MonoBehaviour
{
    public TMP_Text Text;

    public Button buttonRestart;

    public Button buttonExit;

    public TMP_Text GoLevelText;

    void OnTriggerEnter( Collider other )
	{
		GetComponent<AudioSource>().Play();

        Text.text = "Финишь";

        Fin.Finish = true;

        Fin.CountLevel++;

        GoLevelText.text = Fin.CountLevel + "/7";

        buttonRestart.gameObject.SetActive(true);

        buttonExit.gameObject.SetActive(true);
    }
}
