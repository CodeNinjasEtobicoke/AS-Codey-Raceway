using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove FriedChicken;
    public GameObject testBlock;

    // Start is called before the first frame update
    void Start()
    {
        //int testValue = 5;
        //for (int i = 0; i < testValue; i++)
        {
            //for (int j = 0; j < testValue; j++)
            {
                //Vector3 stuff;
                //stuff = transform.position;
                //stuff.z += ((float)i * 1.5f);
                //Instantiate(testBlock, stuff, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //totalLapTime -= Time.deltaTime;
        //totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            FriedChicken.Speed = 0f;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            FriedChicken.Speed = 200f;
        }

        if (totalLapTime < 0)
        {
            print("Time's Up!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }   
    }
}
