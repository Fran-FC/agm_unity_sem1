using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector3(0.0f,2*Input.GetAxis ("Vertical")*Time.deltaTime,0.0f));
        transform.Translate (new Vector3(2*Input.GetAxis ("Horizontal")*Time.deltaTime,0.0f,0.0f));
    }
}
