using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Add text to display counting")]
    [SerializeField]
    Text timeCountTXT;

    [Header("Select time from start counting")]
    public float time;

    [Header("Select the counting mode")]
    public bool countUp;
    public bool countDown;

    private void Start()
    {
        countUp = false;
        countDown = false;
    }

    private void Update()
    {
        TimeCount();
        EndWinGame();
    }

    void TimeCount()
    {
        timeCountTXT.text = time.ToString("0");
        if(countUp == true)
        {
            time += Time.deltaTime;
        }
        else if (countDown == true)
        {
            time -= Time.deltaTime;
        }
    }

    // Example for end/win game or some other solution

    void EndWinGame()
    {
        if(time <= 0)
        {
            // do something
            print("GameOver");
            // time stop at 0
            time = 0;
        }
        if(time >= 10)
        {
            // do something
            print("You Win");
            // time stop at 10
            time = 10;
        }
    }

}

