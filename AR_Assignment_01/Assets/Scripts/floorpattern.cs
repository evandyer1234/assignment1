using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floorpattern : MonoBehaviour
{
    public List<floor> floors;
    bool begin;
    public float interval = 7f;
    float current;
    int squares = 2;
    public GameObject button;
    public GameObject text;

    void Start()
    {
        current = 2f;
        Time.timeScale = 0f;
    }

    
    void FixedUpdate()
    {
        if (begin)
        {
            current -= Time.fixedDeltaTime;
            if (squares >= 24 && current <= 0)
            {
                Win();
                begin = false;
            }
            
            else if (current <= 0)
            {
                active(squares);
                squares = squares + 2;
                current = interval;
            }
        }
    }
    public void active(int amount)
    {
        int y = Random.Range(0, 16);
        while (amount > 0)
        {
            int x = Random.Range(0, 16);
            if (floors[x].on == false || x != y) 
            {
                floors[x].Blink();
            }
            amount--;
            Debug.Log(x);
        }
    }
    public void Go()
    {
        begin = true;
        button.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Win()
    {
        text.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("TI_Scene2");
        Time.timeScale = 0f;
    }
}
