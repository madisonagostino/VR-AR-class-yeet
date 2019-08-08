using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_AI : MonoBehaviour

{   //List Variables
        public float ghostSpeed = 1f; //Ghost speed
        public GameObject ghostStart;
        public boolean turn1;
        public boolean turn2;
        public boolean turn2;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision();
    }

    // Update is called once per frame
    void Update()
    {
        if(turnZero == true)
        {   transform.position += transform.forward * ghostSpeed * Time.deltaTime;  }
        else if (turnOne == true)
        {   transform.position += transform.right * ghostSpeed * Time.deltaTime; }
        else if(turnTwo == true)
        {   transform.position += transform.forward * -ghostSpeed * Time.deltaTime; }
    }

    void OnTriggerEnter(Collider turns)
    {
        if(turns.GameObject.name == "Base 1")
            {turnZero = false;
            turnOne = true;
            Debug.Log("Turn right"); }
        else if(turns.GameObject.name == "Base 2")
            {turnOne = false;
            turnTwo = true;}
    }
}
