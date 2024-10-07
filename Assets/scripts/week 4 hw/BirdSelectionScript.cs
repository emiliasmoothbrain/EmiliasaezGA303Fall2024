using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelection : MonoBehaviour
{
    public List<NewBird> Birdlist = new List<NewBird>();
    public int selectedBird;
    public AudioSource Pikminbeat;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Birdlist.Count);
        Pikminbeat = GetComponent<AudioSource>();
        
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
        if (Input.GetKeyDown(KeyCode.DownArrow))
        { CurrentBirdDance(); }


        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            playmusic();
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
        Debug.Log("Birdselect is increasing");
       
        
        if (selectedBird < Birdlist.Count - 1) 
        {
       
            selectedBird++;
            Debug.Log("The counter is " + selectedBird);
        }
    }

    public void BirdSelectDecrease()
    {
        Debug.Log("Birdselect is Decreasing");
        if (selectedBird > 0)
        {
         
            selectedBird--;
            Debug.Log("The counter is " + selectedBird);
        }


    }

    public void playmusic()
    {
        if (selectedBird >= 1)
            Debug.Log("the audio will now play");
            Pikminbeat.Play();

    }

}

