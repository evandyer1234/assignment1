using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Camera camera;
    public MoveTo spot;
    public agent guy;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                MoveTo clone;
                clone = Instantiate(spot, new Vector3 (hit.point.x, hit.point.y, hit.point.z), transform.rotation);
                //guy.Target(hit.point);

                //MoveTo MT = guy.gameObject.AddComponent(typeof(MoveTo)) as MoveTo;

               
                clone.endpos = hit.point;
                clone.startpos = guy.gameObject.transform.position;
                clone.guy = guy;
                guy.points.Add(clone);
                guy.stop = false;
                
            }
        }
    }
}
