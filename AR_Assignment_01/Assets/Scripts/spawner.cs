using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public int amount = 5;
    public float interval = 2f;
    float current;
    public float xvalue = 1f;
    public float center = 1f;
    
    public float zvalue = 1f;
    public float yvalue = 1f;
    public enemy en;
    public bool begin = false;
    public GameObject goal;
    public GameObject text;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        current = interval;
    }
    public void Go()
    {
        begin = true;
        button.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (begin)
        {
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                if (amount > 0)
                {
                    current = interval;

                    enemy clone;
                    clone = Instantiate(en, new Vector3(Random.Range(center - xvalue, center + xvalue), yvalue, zvalue), transform.rotation);
                    clone.Target(goal.transform.position);
                    amount--;
                    
                }
                else
                {
                    win();
                }
            }
        }
    }
    public void win()
    {
        text.SetActive(true);
        Time.timeScale = 0f;
    }
}
