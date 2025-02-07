using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    /// <summary> What a variable needs:
    /// 1. public of private reference
    /// 2. data type (string, bool, float, int)
    /// 3. name of variable
    /// 4. optional -- a value
    /// </summary>

    //variable for my name
    //variable for my age
    //variable for my location
    public string myName = "Luis";
    public int myAge = 23;
    private string location = "USA"; //I don't want the rest of the world to know my location!!

    void Start()
    {
        print("My name is: " + myName);
        print("My age is: " + myAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
