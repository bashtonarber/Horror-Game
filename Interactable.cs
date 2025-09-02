using TreeEditor;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   
    public virtual void Interact()
    {
        //Debug.Log("Pickeed");
    }

    void Update()
    {

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Interact();
        }
    }
}
