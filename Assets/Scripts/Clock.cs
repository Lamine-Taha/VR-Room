using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        // Get current system time
        DateTime currentTime = DateTime.Now;
        Debug.Log(currentTime.ToString());

        // Extract hour, minute, and second
        int hours = currentTime.Hour;
        int minutes = currentTime.Minute;
        int seconds = currentTime.Second;

        // Calculate rotation angles for clock hands
        float hourAngle = (hours % 12) * 30f - (minutes / 60f) * 30f + 90f; // 30 degrees per hour
        float minuteAngle = minutes * 6f +90f ; // 6 degrees per minute
        float secondAngle = seconds * 6f + 90f; // 6 degrees per second


        // Rotate clock hands
        hourHand.localRotation = Quaternion.Euler(hourAngle, 0f, 0f);
        minuteHand.localRotation = Quaternion.Euler(minuteAngle, 0f, 0f);
        secondHand.localRotation = Quaternion.Euler(secondAngle, 0f, 0f);
    }
}
