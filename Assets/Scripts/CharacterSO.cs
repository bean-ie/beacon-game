using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "ScriptableObjects/Character")]
public class CharacterSO : ScriptableObject
{
    public string characterName;
    public Sprite worldSprite;
    public string[] activeAbilities;
    public string[] passiveAbilities;
    public float movementSpeed;
    public float maxSpeed;
    public float maxHP;
}
