using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emiliaSaezVariableScript1 : MonoBehaviour
{
    public Light heatLight;
    public firescripttest otherScript;
    public Image thumbsUpShrimp;



    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    public void Lighttoggling(bool LightOn)
    {
        heatLight.enabled = LightOn;
        if(otherScript.enabled == true)
        {
            heatLight.color = Color.red;
            heatLight.enabled = true;

        }
        
       
        














    }












}



