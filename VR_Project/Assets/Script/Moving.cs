using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
        //Variables
            
            public float speed = 0.5f;    // used to control the speed of our movement
            public GameObject Camera;   //This will be used to reference our camera 
            public Vector3 spawnPoint;
            public GameObject Door;
            public GameObject Key;
            public bool gotKey = false;
            public bool doorUnlocked = false;
        
        // Start is called before the first frame update
    void Start()
    {

        spawnPoint = transform.position; //We are setting the location of the transform set to our VR camera's starting position when the game begins

    }

        // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {

        transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        
        }

        else if (Input.touchCount > 0)
        {
        transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }
        if (doorUnlocked == true)
        {
            OpenDoor();
        }
 
    }
    void OnTriggerEnter(Collider collide)
{
        if(collide.gameObject.tag == "Respawn")
        {
        transform.position = spawnPoint;
        Debug.Log("Collide"); 
        }
        else if (collide.gameObject.tag == "Door")
        {
            doorUnlocked = true;
        }



   }
    void OpenDoor()

    {
        Quaternion newRotation = Quaternion.AngleAxis(-90, Vector3.up);
            
            Door.transform.rotation = Quaternion.Slerp(Door.transform.rotation, newRotation, .05f);

            Door.tag = "Untagged";
    }



    void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.tag == "Key"){

            gotKey = true;
            Destroy(Key);
        }


    }
}
