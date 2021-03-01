using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
   
    private float time;
    
    public bool B = false;
    //Press Button
    public bool A = false;
    //delete objekt
    public bool C = false;
    //3 second space
    public bool D = false;
    // 1 2 3 4 gedrückt

    public GameObject image;


    bool einsPressed; 
    bool zweiPressed;
    bool dreiPressed;
    bool vierPressed;

    public void ButtonPress()
    {
        B = true;
        Debug.Log("Button Pressed");
        
    }
    public void Deletebutton()
    {
        A = true;
        image.SetActive(false);
        Debug.Log("image deleted");
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            time = 0;
        }
        if (time > 3)
        {
            C = true;
            Debug.Log("3 second Press" + time);
            time = 0;
        }
        // Leertaste für 3 secunden gedrückt halten


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            einsPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            zweiPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dreiPressed = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            vierPressed = true;
        }
        if(einsPressed && zweiPressed && dreiPressed && vierPressed)
        {
            D = true;
        }
        // 1 2 3 4 gedrückt



        Debug.Log("auswertung:"+((A && B)||(B && C)||(C && D)));
    }
}

    




    



    

