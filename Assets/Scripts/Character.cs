using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public CharacterSO characterSO { get; private set; }
    public float movementSpeed;
    public float maxSpeed;
    public float maxHP;
    public float currentHP;

    public ActiveAbility[] activeAbilities;
    public Character(CharacterSO character)
    {
        characterSO = character;

        activeAbilities = new ActiveAbility[character.activeAbilities.Length];
        for (int i = 0; i < character.activeAbilities.Length; i++)
        {
            if (character.activeAbilities[i] != string.Empty)
            {
                activeAbilities[i] = (ActiveAbility)Activator.CreateInstance(IDManager.activeAbilities[character.activeAbilities[i]]);
                activeAbilities[i].owner = this;
            }
        }
        // TODO: add passive abilities

        movementSpeed = character.movementSpeed;
        maxSpeed = character.maxSpeed;
        maxHP = character.maxHP;
        currentHP = maxHP;
    }
}
