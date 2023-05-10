using UnityEngine;
using System.Collections;
using Assets.Scripts;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class BallScript : MonoBehaviour
{
    public GameObject MainCamera;
   
    public float speed; 
    
    public Rigidbody body;

    public Button buttonRestart;

    public Button buttonExit;

    public TMP_Text GoLevelText;

    private void Start()
    {
        buttonRestart.gameObject.SetActive(false);
        buttonExit.gameObject.SetActive(false);

        GoLevelText.text = Fin.CountLevel + "/7";
    }

    void Update()
    {
        if (!Fin.Finish)
        {
           
            if (Input.GetKey(KeyCode.W))
            {
                body.AddForce(MainCamera.transform.forward * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                body.AddForce(-MainCamera.transform.forward * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                body.AddForce(MainCamera.transform.right * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                body.AddForce(-MainCamera.transform.right * speed * Time.deltaTime);
            }
        }
        float speed1 = Mathf.Clamp(body.angularVelocity.magnitude / 10, 0, 1);
        float vol = GetComponent<AudioSource>().volume;
        GetComponent<AudioSource>().volume = vol + (((speed1 / 2) - vol) * Time.deltaTime * 10);
        GetComponent<AudioSource>().pitch = 1.05f + (speed1 / 4);
    }

    public void Reset()
    {
        Fin.Finish = false;
        Timer.timerStart = 0;
        Fin.CountLevel = 0;
    }
}
