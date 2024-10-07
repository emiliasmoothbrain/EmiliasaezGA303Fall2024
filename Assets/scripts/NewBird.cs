using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class NewBird : MonoBehaviour
{
    public Sprite egg;
    public Sprite birdSquish;
    public Sprite birdStretch;
    public Sprite CrackeggSprite;
    public Image BirdImageholder;
    public bool isEgg = true;
    public int counterToDance;


    // Start is called before the first frame update
    void Start()
    {
        BirdImageholder.sprite = egg;
        if (BirdImageholder.sprite == egg) { isEgg = true; }
        else { isEgg = false; }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hatch that lil guy");
            if (isEgg == true)
            {
                BirdImageholder.sprite = CrackeggSprite;
            }
        }


    


    }
 
        public void Dancelilman()
    {
        counterToDance++;
        if (counterToDance % 2 == 0)
        {
            BirdImageholder.sprite= birdStretch;

        }
        else if (counterToDance % 2 == 1)
        {
            BirdImageholder.sprite = birdSquish;


        }
        else { return; }

        // public void crackegg(bool uncracked)
        // {
        //  if (BirdImageholder == egg)
        //  {
        //     uncracked = true;
        //    egg = CrackeggSprite;

        //  }
        // else uncracked = false;
        //  if (uncracked== false) { BirdImageholder.sprite = birdSquish; }

        // }
        //public 
    }


}
