using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Characters", menuName = "CharacterLists")]
public class ScritableObjectScript : ScriptableObject
{
    public string characterName;
    public string description;

    public Sprite picture;

    public int page;
}
