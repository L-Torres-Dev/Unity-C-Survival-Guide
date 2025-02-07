using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //create a variable to store your name
    //create a variable to store your age
    //create a variable to store your speed
    //create a health variable
    //create a score variable
    //create a speed variable
    //variable to check if all keys were collected
    //variable for ammo count

    public string myName = "Luis";
    public int age = 23;
    public int health = 3;
    public int score;
    public float speed = 5.5f;
    public bool allKeysCollected;
    public int ammoCount = 30;

    private void Start()
    {
        print(GetData());
    }

    public string GetData()
    {
        return $"name: {myName} age: {age} health: {health} score: {score} " +
            $"speed: {speed} allKeysCollected: {allKeysCollected} ammo count: {ammoCount}";
    }
}
