using System;
using TMPro;
using UnityEngine;

public class UITime : MonoBehaviour
{
    private static float raceTime;
    public static bool gameStarted = false;

    private TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (gameStarted)
        {
            raceTime += Time.deltaTime;
        }

        if (textMeshProUGUI != null)
        {
            textMeshProUGUI.text = "Time: " + Math.Round(raceTime, 2);
        }
    }

    public static void ResetTime()
    {
        raceTime = 0f;
        gameStarted = false;
    }

    public static float GetRaceTime()
    {
        return raceTime;
    }
}
