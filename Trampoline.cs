using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int JumpIncrease = 2;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= JumpIncrease; //Increase the player's jump strength.
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpIncrease; //Return the player's jump strength to default.
    }
}
