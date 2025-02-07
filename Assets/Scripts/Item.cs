using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //ever item has a name
    //every item has a description
    //every item has an image

    public string itemName;
    public string description;
    public Sprite sprite;
    public int attack;

    void Start()
    {
        print("Name: " + itemName);
        print("Description: " + description);
        print("Attack: " + attack);
    }
}
