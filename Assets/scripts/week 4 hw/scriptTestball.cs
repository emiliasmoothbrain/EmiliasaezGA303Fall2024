using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptTestball : MonoBehaviour
{
    public GameObject straightBallin;
    public int counter = 0;
    public int Speed = 0;
    public Image thumbsUpShrimp;

    // Start is called before the first frame update
    void Start()
    {
        straightBallin = GameObject.Find("ballUp");
        // straightBallin.SetActive(false);
        straightBallin.SetActive(true);
        thumbsUpShrimp.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
            Debug.Log("counter is 1");

        // CheckInputs()
        if (Input.GetKeyDown(KeyCode.D))
        {
            counter++; 
        }
        if (Input.GetKeyDown(KeyCode.A))
        { 
            counter--; 
        }
        if (counter == 1)
        {
            straightBallin.transform.Translate(Vector3.down * Time.deltaTime * Speed);
        }
    }




    public void flipShrimp()
    {
        {
            if (Input.GetKeyDown(KeyCode.S))
                thumbsUpShrimp.rectTransform.Rotate(new Vector3(0f, 180f, 0f));

        }













    }


















}
//void CheckInputs();

