using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0 && minutes != 0)
        {
            minutes -= 1;
            seconds = 59f;
        }
        else if (seconds <= 0)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        timerText.text = minutes.ToString("00") + ":" + Mathf.FloorToInt(seconds).ToString("00");
    }
}
