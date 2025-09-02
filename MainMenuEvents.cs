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
    private UIDocument _document;

    private Button _button;

    private List<Button> _menuButtons = new List<Button>();

    private AudioSource _audioSource;

    void Awake()
    {
        _document = GetComponent<UIDocument>();
        _audioSource = GetComponent<AudioSource>();

        _button = _document.rootVisualElement.Q("StartGameButton") as Button;
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick);

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

    void OnPlayGameClick(ClickEvent evt)
    {
        print("StartButton Pressed");
        SceneManager.LoadScene("TestScene");
    }

    void OnAllButtonsClick(ClickEvent evt)
    {
        _audioSource.Play();
    }
}

