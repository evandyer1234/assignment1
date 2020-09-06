using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Camera camera;
    public ball b;
    public GameObject spawnpoint;

    void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.GetTouch(0).position);

        if (Physics.Raycast(ray, out hit))
        {
            //Transform objectHit = hit.transform;
            if (hit.transform.tag == "Bad");
            {
                ball b = hit.collider.gameObject.GetComponent(typeof(ball)) as ball;
                if (b != null)
                {
                    b.held = true;
                }

                
            }
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene("TI_Scene1");
        Time.timeScale = 1f;
    }
    public void Start()
    {

    }

}
