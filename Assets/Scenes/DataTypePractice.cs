using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class dataTypepractice : MonoBehaviour
{
    //Variables for script 2
    public int hundokilo = 100000; //value is 100k
    public int fiddykilo = 50000; // 50k
    public int addIntTotal; // addition total
    public long bigolnumber = 2000000000; //2 bil
    public long evenbiggernumber = 5000000000; // 5 bil
    public long subLongTotal;
    public float wowdecimal = 0.0754f; // lilguy
    public float itemprice =175.99f;
    public float multFloatTotal; //multiplication total
    public double iddybittynum = 2.7182819; //oiler num e 
    public double exvalue = 2.111115; // experimental value to divide
    public double divDoubleTotal;
    public int totalCount = 0; // this will be the count that helps me check the debug after 3 cycles 

    //Variables for Script 1
    public char arbok = 'a';
    public char piplup = 'p';
    public char lapras = 'l';
    public char empoleon = 'e';
    public float total;



    // variables for script 3 
    public string message1 = "wow script one is frustrating me  ";
    public string message2 = " it keeps breaking T-T ";
    public string message3 = " and I'm just like I wanna spell apple man  ";
    public string message4 = " pov you're 5 ";





    // Start is called before the first frame update
    void Start()
    {

        //SCRIPT 1
        Debug.Log(arbok.ToString()+ piplup.ToString() + piplup.ToString() + lapras.ToString() + empoleon.ToString());

     //   total = arbok + piplup + piplup + lapras + empoleon;
        //Debug.Log(total.ToString());










        //SCRIPT 2
        // first cycle 
        addIntTotal = hundokilo + fiddykilo;
        subLongTotal = bigolnumber - evenbiggernumber;
        multFloatTotal = wowdecimal * itemprice;
        divDoubleTotal = iddybittynum / exvalue;
        totalCount = totalCount + 1;
        Debug.Log("addition equation total is" + addIntTotal);
        Debug.Log("subtraction equation total is" + subLongTotal);
        Debug.Log("multiplication equation total is" + multFloatTotal);
        Debug.Log("division equation total is" + divDoubleTotal);
        Debug.Log("Results after 1st cycle:" + totalCount);
        // 2nd cycle

        addIntTotal = hundokilo + fiddykilo + addIntTotal;
        subLongTotal = bigolnumber - evenbiggernumber - subLongTotal;
        multFloatTotal = wowdecimal * itemprice * multFloatTotal;
        divDoubleTotal = iddybittynum / exvalue / divDoubleTotal;
        totalCount = totalCount + 1;
        Debug.Log("addition equation total is" + addIntTotal);
        Debug.Log("subtraction equation total is" + subLongTotal);
        Debug.Log("multiplication equation total is" + multFloatTotal);
        Debug.Log("division equation total is" + divDoubleTotal);
        Debug.Log("Results after 2nd cycle:" + totalCount);
        // 3rd cycle

        addIntTotal = hundokilo + fiddykilo + addIntTotal;
        subLongTotal = bigolnumber - evenbiggernumber - subLongTotal;
        multFloatTotal = wowdecimal * itemprice + multFloatTotal;
        divDoubleTotal = iddybittynum / exvalue / divDoubleTotal;
        totalCount = totalCount + 1;
        Debug.Log("addition equation total is" + addIntTotal);
        Debug.Log("subtraction equation total is" + subLongTotal);
        Debug.Log("multiplication equation total is" + multFloatTotal);
        Debug.Log("division equation total is" + divDoubleTotal);
        Debug.Log("Results after 3rd cycle:" + totalCount);

        //end of script 2

        // SCRIPT 3 
        Debug.Log(message1 + message2 + message3 + message4);





    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
