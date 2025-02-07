using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /**
     * There are many different kinds of data types
     * primitive data types (like int, float, and bool)
     * 
     * reference data types (like GameObject, Animator, Transform)
    **/

    //Primitive Data Types
    public int score;
    public float speed = 5.5f;
    public bool hasKey = true;

    //Reference Data Types
    public GameObject player;
    public Animator anim;
    public Transform myTransform;
    void Start()
    {
        print(myTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
