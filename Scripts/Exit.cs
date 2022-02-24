using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;

public class Exit: MonoBehaviour 
{
    public void OnButtonPress() 
    {  
        Debug.Log("Game exited");  
        Application.Quit();  
    }  
}