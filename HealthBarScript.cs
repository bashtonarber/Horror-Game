using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
/* 
This script controls the players health bar which is displayed in the top left corner.

The script is kept simple as it just needs to deduct away the set value.

Currently it deducts when the L key is pressed, this is purely for testing purposes, but the float used for the current health is static so it can be used in other scripts. 
*/

    //The image that will be used. 
    private Image healthBar;

    //The floats to cover the current player health and the max health - Both are static so they can be used in toher scripts. 
    public static float curHealth;
    public static float maxHealth;
    
    void Start()
    {
        maxHealth = 100; //Ensuring that the max health is always at 100 when the game starts. 
        curHealth = maxHealth; //Ensuring that the health bar is full at the start.
        healthBar = gameObject.GetComponent<Image>(); //Grabbing the component from the object the script is attached to, in this case it's the image component.
    }

    void Update()
    {
        healthBar.fillAmount = curHealth / maxHealth; //Ensuring that the fill amount of the image component is equal to what the current health is. 

        if (Input.GetKeyDown(KeyCode.L)) //Test function to make sure that the healthbar deducts correcty - This will be removed at a later date.
        {
            curHealth -= 10;
        }   
    }
}

