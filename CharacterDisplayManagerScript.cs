using UnityEngine;

public class CharacterDisplayManagerScript : MonoBehaviour
{
      public GameObject[] characterDisplays;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
        characterDisplays[0].SetActive(false);
        characterDisplays[1].SetActive(false);
    }

    // Update is called once per frame
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
