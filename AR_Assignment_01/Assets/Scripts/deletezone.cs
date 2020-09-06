using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletezone : MonoBehaviour
{
    public ball b;
    public GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.transform.tag == "Bad")
        {
            ball clone;
            clone = Instantiate(b, spawnpoint.transform.position, transform.rotation);
        }
        Destroy(collision.gameObject);
    }
}
