using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completetrigger : MonoBehaviour
{
    public GameObject platedoneyay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerExit(Collider other)
    { if(other.gameObject.tag == "HotDog")
        Debug.Log("Thanks for the hotdog");
    }


}
