using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class MainMenuEvents : MonoBehaviour
{

/* 
Main Menu - To work with the Unity UI Toolkit.

This script was written as a way to play around with the UI Toolkit and to see how efficient it is to create a menu that is used frequently. 
After having a play around with it, the flow of it proved to be really useful and feels just as good as the UI Canvas.

*/
     // UIDocument that will be used throughout.
    private UIDocument _document;

    // Button variable that will be used to line up with the UIDocument. - Currently only the Start Game button is set up.
    private Button _button;

    // The list for the buttons that will be checked. - This is then used in the OnAllButtonsClick function.
    private List<Button> _menuButtons = new List<Button>();

    // AudioSources that will be used
    private AudioSource _audioSource;

    //Awake function to trigger on launch.
    void Awake()
    {
        //Getting the required components for this script that are on the same object.
        _document = GetComponent<UIDocument>();
        _audioSource = GetComponent<AudioSource>();

        _button = _document.rootVisualElement.Q("StartGameButton") as Button; //Getting the StartGameButton from the UIToolkit.
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick); //Setting the function that the button will use.

        //Gets each button within the UIToolkit to use the OnAllButtonsClick function so the audio used for the button press plays. 
        _menuButtons = _document.rootVisualElement.Query<Button>().ToList();
        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].RegisterCallback<ClickEvent>(OnAllButtonsClick);
        }
    }

    void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnPlayGameClick);

        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonsClick);
        }
    }

    //Function to load into the game level scene - This is used with the UIDocument button.
    void OnPlayGameClick(ClickEvent evt)
    {
        //print("StartButton Pressed"); - Debug that was used for testing.
        SceneManager.LoadScene("TestScene"); //The Test Scene is the main scene being used to to test various UI features being implemented.
    }
    
    //Function to play a sound when a button is pressed - This is used with the UIDocument button.
    void OnAllButtonsClick(ClickEvent evt)
    {
        _audioSource.Play();
    }
}


