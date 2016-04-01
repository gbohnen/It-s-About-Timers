using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calibration : MonoBehaviour {

    public float metronomeInterval;
    public float calibrationMax;




    public GameObject circle;
    public GameObject timerField;
    public GameObject intervalField;

    public InputField timer;
    public InputField interval;

    public float calibrationTimer;
    public float intervalTimer;
    public int mode;

    public void Start()
    {
        timer = timerField.GetComponent<InputField>();
        interval = timerField.GetComponent<InputField>();

        interval.onValueChanged.AddListener(delegate { SetInterval(); });
    }


    public void SetTimer()
    {

    }

    public void SetInterval()
    {
        Debug.Log(timer.text);
    }

    public void StartTimer()
    {

    }



}
