using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelectionScript : MonoBehaviour
{
    public List<NewBird> Birdlist = new List<NewBird>();
    public int selectedBird;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Birdlist.Count);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BirdSelectIncrease();


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BirdSelectDecrease();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            EveryoneDance();
        }
    
    
    
    
    
    
    
    
    
    }




    public void CurrentBirdDance()
    {
        Birdlist[selectedBird].Dancelilman();
    }
    public void EveryoneDance()
    {

        for (int i = 0; i < Birdlist.Count; i++)
        {
            Birdlist[i].Dancelilman();
        }
    }


    public void BirdSelectIncrease()
    {

        if (selectedBird < Birdlist.Count - 1) { selectedBird++; }
    }

    public void BirdSelectDecrease()
    {

        if (selectedBird > 0) { selectedBird--; }



    }
}

