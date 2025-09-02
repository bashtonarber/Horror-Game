using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicScrollView : MonoBehaviour
{
    [SerializeField]
    private Transform scrollViewcontent;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private List<Sprite> images;

    void Start()
    {
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
