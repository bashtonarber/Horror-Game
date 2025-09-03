using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicScrollView : MonoBehaviour
{

/*

This script wasfor a scroll view that I was playing around with for the Inventory Menu to make it more flexible to scroll.
This design was changed when I realised that the Horror game will be smaller and not have enough items for it. - This has been kept in just in case the design changes. 

*/
    // Declaring the ScrollView component - Set to as a SerializeField so it appears in the Inspector still. 
    [SerializeField]
    private Transform scrollViewcontent;

    //The prefab that will be used for the location. 
    [SerializeField]
    private GameObject prefab;
    
    //Declaring a list for the images that will be used. 
    [SerializeField]
    private List<Sprite> images;

    void Start()
    {
        //Setting the images within the list of the ScrollView.
        foreach (Sprite images in images)
        {
            GameObject newImage = Instantiate(prefab, scrollViewcontent);
            if (newImage.TryGetComponent<ScrollViewItem>(out ScrollViewItem item))
            {
                item.ChangeImage(images);
            }
        }
    }

}

