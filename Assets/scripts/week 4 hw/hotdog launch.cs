using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using Unity.VisualScripting;
using UnityEngine;

public class hotdoglaunch : MonoBehaviour
{
    public GameObject hotdogvariable;
    public float hotdogSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
           

    }

    // Update is called once per frame
    void Update()
    {
        




 
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Lime Of Doom")
        {
           this.GetComponent<Rigidbody>().AddForce(this.transform.right * hotdogSpeed); }

    }
    public void OnCollisionEnter(Collision otherobject)
    {
        if (otherobject.gameObject.tag == "Bbq")
            this.GetComponent<Rigidbody>().AddForce(this.transform.up * hotdogSpeed);

    }
}











