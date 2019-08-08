using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
public GameObject Door_Wood
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        if(gate.gameObject.tag == "Door_Wood")
        {
            transform.position = tp to maze1.transform.position;
        }
    }
}
