using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class firescripttest : MonoBehaviour
{
    public SpriteRenderer firespriteRef;
    public SpriteRenderer ingredientRef;
    public Sprite cookedRice;
    public emiliaSaezVariableScript1 LightScript;
    // Start is called before the first frame update
    void Start()
    {
       




    }

    // Update is called once per frame
    void Update()
    {
        






    }


    public void ingredientDrop(bool isDroppin)
    {
        ingredientRef.enabled = isDroppin;






    }


    public void turnOnFire(bool fireOn)
    {
        firespriteRef.enabled = fireOn;
        if(ingredientRef.enabled == true)
            
        {
            if (firespriteRef.enabled == true)
            {
                ingredientRef.sprite = cookedRice;
                firespriteRef.enabled = false;

                if (firespriteRef.enabled==true)
                {

                    LightScript.enabled = true;
                   
                }

            }




        }
    
    
    
    
    
    
  
    
    
    }





}



