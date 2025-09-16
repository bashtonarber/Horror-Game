using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Characters", menuName = "CharacterLists")]
public class ScritableObjectScript : ScriptableObject
{

/*

this script was a test of setting up a scriptable object which is currently used for setting up characters in the players notebook that will be within the game. 

*/
    public string characterName;
    public string description;

    public Sprite picture;

    public int page;
}

