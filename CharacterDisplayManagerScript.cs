using UnityEngine;

public class CharacterDisplayManagerScript : MonoBehaviour
{

/*

This script was quickly written up to switch between each character display and mainly currently just used for testing purposes and will be updated at a later date.

*/

      public GameObject[] characterDisplays;
//Bools will be added here to go with each character, most likely as an array. 

      
    void Start()
    {        
        characterDisplays[0].SetActive(false);
        characterDisplays[1].SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!characterDisplays[0].activeInHierarchy)
            {
                characterDisplays[0].SetActive(true);
            }
            else if (characterDisplays[0].activeInHierarchy)
            {
                characterDisplays[0].SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (!characterDisplays[1].activeInHierarchy)
            {
                characterDisplays[1].SetActive(true);
            }
            else if (characterDisplays[1].activeInHierarchy)
            {
                characterDisplays[1].SetActive(false);
            }
        }
    }
}

