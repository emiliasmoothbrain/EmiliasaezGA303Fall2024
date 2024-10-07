using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LimeInstantiation : MonoBehaviour
{
    public GameObject limeSpawn;
    public Transform spawnLocation;
    public float Speed = 500.0f;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //  GameObject Limeprefab = if (!Input.GetKeyDown(KeyCode.W))
        if (Input.GetKeyDown(KeyCode.Space))
        {

             GameObject Limeprefab = Instantiate(limeSpawn, spawnLocation.position, spawnLocation.rotation); 
            Debug.Log("lime is spawning");
            { Limeprefab.GetComponent<Rigidbody>().AddForce(Limeprefab.transform.up * Speed); }
        }
    }


   // public void OnCollisionEnter(Collision otherObject)

    
       // Debug.Log("I killed the plate its time to get outta here");
       // if (otherObject.collider.gameObject.tag == "Plate and Hotdog")
        
           // GameObject Limeprefab = limeSpawn;
         //   Limeprefab.GetComponent<Rigidbody>().AddForce(Limeprefab.transform.forward * Speed);

        }









    


    