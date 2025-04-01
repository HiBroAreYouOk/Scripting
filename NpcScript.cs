using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    public int npcLevel; //Set the variables
    public int npcLives;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        int npcHealth;//Create the health variable
        npcHealth = npcLevel + npcLives; //Calculate the actual npc health by adding its level and its health
        print("The health of the npc is:" +  npcHealth); //Print the health of the npc
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
