using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class week6playerscript : MonoBehaviour
{

    public bool GreenInInventory = false;
    public bool BlueInInventory = false;
    public bool RedInInventory = false;
    public Transform PlayerCamera;
    public week6doorscript DoorScript;
    public int redKeyCounter;
    public int blueKeyCounter;
    public int greenKeyCounter;
    public week6keyscript Keyscript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (blueKeyCounter >= 1)
        {
            Debug.Log("you've collected a bluekey");
        }
        if (redKeyCounter >= 1)
        {
            Debug.Log("you've collected a redkey");
        }
        if (greenKeyCounter >= 1)
        {
            Debug.Log("you've collected a greenkey");
        }

    }
    public void AddKey()
    {
        week6keyscript Keyscript = GetComponent<week6keyscript>();
        if (Keyscript.keycolor == keyNDoorColor.Green)
        {
            greenKeyCounter++;
        }
        else if (Keyscript.keycolor == keyNDoorColor.Red)
        {
            redKeyCounter++;
        }
        else if (Keyscript.keycolor == keyNDoorColor.Blue)
        {
            blueKeyCounter++;
        }
        else { return; }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            week6keyscript Keyscript = other.GetComponent<week6keyscript>();
            if (Keyscript.keycolor == keyNDoorColor.Blue)
            {
                AddKey();
                Debug.Log("the bluekey count is" + blueKeyCounter);
            }
            else if (Keyscript.keycolor == keyNDoorColor.Green)
            {
                AddKey();
                Debug.Log("the green key count is" + greenKeyCounter);
            }
            else if (Keyscript.keycolor == keyNDoorColor.Red)
            {
                AddKey();
                Debug.Log("the red key count is" + redKeyCounter);

            }
        }

    }
}



