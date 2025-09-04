using TreeEditor;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   

/*

This script is attached to the item object that gets picked up and then calls the Interact function.

*/
    public virtual void Interact()
    {
        //Debug.Log("Pickeed"); //Old debug to the console to make sure its working.
    }

    void Update()
    {

    }


    //Collision trigger function that calls the Interact function when the player walks into it - This may change to no longer collide but a Button to pick up instead.
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Interact();
        }
    }
}
