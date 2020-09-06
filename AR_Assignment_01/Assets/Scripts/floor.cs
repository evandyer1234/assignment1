using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public Color colornorm;
    public Color colordisp;
    public Color trans;

    Renderer rend;

    public Collider block;

    public float blinktime = 2f;
    float current;

    public bool on = false;

    public float offlimit = 3f;
    float fl;

    void Start()
    {
        current = blinktime;
        fl = offlimit;
        rend = GetComponent<Renderer>();
    }

    
    void FixedUpdate()
    {
        if (on)
        {
            current -= Time.fixedDeltaTime;
            if (current <= 0)
            {
                rend.material.color = trans;
                block.enabled = false;
                fl -= Time.fixedDeltaTime;
                if (fl <= 0)
                {
                    on = false;
                    block.enabled = true;
                    rend.material.color = colornorm;
                    fl = offlimit;
                    current = blinktime;
                }
            }
        }
    }
    public void Blink()
    {
        on = true;
        rend.material.color = colordisp;
    }
    
}
