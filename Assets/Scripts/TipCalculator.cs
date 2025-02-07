using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    // bill is $40
    // tip is 20% or based on what the user wants
    // calculate total ammount

    public float bill;
    public float tip = .2f;

    void Start()
    {
        //Your bill is: and your tip amount is: so you owe: total ammount
        float tipAmmount = bill * tip;
        float total = tipAmmount + bill;
        print($"Your bill is: {bill} and your tip amount is: {tipAmmount} so you owe: {total}");

    }
}
