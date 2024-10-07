using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonPlate : MonoBehaviour
{
    public GameObject plate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision otherObject)
    { Debug.Log("I'm just a plate minding my business Surely I wont be hit by" + otherObject.collider.gameObject.name);
        if (otherObject.collider.gameObject.tag == "Lime Of Doom")
            Debug.Log("FUCK IT'S THE LIME OF DOOM");
        Debug.Log("is my purpose to simply be a barrier in the transport of a hotdog CURSE YOU LIME OF DOOM");
        Destroy(this.gameObject);
    }

        
    }










