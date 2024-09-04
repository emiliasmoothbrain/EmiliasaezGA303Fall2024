using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emiliasaezReferenceAndFunctionPractice : MonoBehaviour
{
    public Image fireref;
    public Image ingredientRef;
    public Image cookedFoodRef;


    public Sprite FireForPan;
    public Sprite rawIngredients;
    public Sprite cookedRice;
    // Start is called before the first frame update
    void Start()
    {
        fireref.Sprite = FireForPan;

        FireForPan.Sprite.SetActive(false);
      
      //GameObject.Find("ingredientsAndFire").SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
