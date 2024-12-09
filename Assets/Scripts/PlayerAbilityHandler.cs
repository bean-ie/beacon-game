using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilityHandler : MonoBehaviour
{
    PlayerManager teamManager;

    private void Awake()
    {
        teamManager = GetComponent<PlayerManager>();
        PlayerControls playerControls = new PlayerControls();

        playerControls.Player.Ability1.Enable();
        playerControls.Player.Ability2.Enable();
        playerControls.Player.Ability3.Enable();
        playerControls.Player.Ability4.Enable();

        playerControls.Player.Ability1.performed += UseAbility1;
        playerControls.Player.Ability2.performed += UseAbility2;
        playerControls.Player.Ability3.performed += UseAbility3;
        playerControls.Player.Ability4.performed += UseAbility4;
    }

    private void UseAbility1(InputAction.CallbackContext context)
    {
        if (teamManager.GetCurrentCharacter().activeAbilities.Length > 0)
        {
            teamManager.GetCurrentCharacter().activeAbilities[0].UseAbility();
        }
    }
    private void UseAbility2(InputAction.CallbackContext context)
    {
        if (teamManager.GetCurrentCharacter().activeAbilities.Length > 1)
        {
            teamManager.GetCurrentCharacter().activeAbilities[1].UseAbility();
        }
    }
    private void UseAbility3(InputAction.CallbackContext context)
    {
        if (teamManager.GetCurrentCharacter().activeAbilities.Length > 2)
        {
            teamManager.GetCurrentCharacter().activeAbilities[2].UseAbility();
        }
    }
    private void UseAbility4(InputAction.CallbackContext context)
    {
        if (teamManager.GetCurrentCharacter().activeAbilities.Length > 3)
        {
            teamManager.GetCurrentCharacter().activeAbilities[3].UseAbility();
        }
    }
}
