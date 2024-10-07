using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mustard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.collider.tag == "Lime Of Doom")
            Debug.Log("Oh hi im a mustard bottle i dont get visits often");
    }


    public void OnCollisionExit(Collision otherObject)
    {
        if (otherObject.collider.tag == "Lime Of Doom")
            Debug.Log("oh no where are you going what did I do");
    }







}

