using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] CharacterSO[] teamSetup;
    Character[] team;
    int currentTeamMember = 0;
    SpriteRenderer spriteRenderer;
    PlayerMovement playerMovement;

    public delegate void SwitchCharacterEventHandler(Character newCharacter);

    public event SwitchCharacterEventHandler switchCharacter;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMovement = GetComponent<PlayerMovement>();
        SetupTeam();
        UpdateCurrentCharacter();
        PlayerControls controls = new PlayerControls();
        controls.Player.Character1.Enable();
        controls.Player.Character2.Enable();
        controls.Player.Character3.Enable();
        controls.Player.Character4.Enable();

        controls.Player.Character1.performed += SwitchToCharacter1;
        controls.Player.Character2.performed += SwitchToCharacter2;
        controls.Player.Character3.performed += SwitchToCharacter3;
        controls.Player.Character4.performed += SwitchToCharacter4;
    }

    private void SwitchToCharacter1(InputAction.CallbackContext context)
    {
        if (team.Length < 1)
            return;
        currentTeamMember = 0;
        UpdateCurrentCharacter();
    }
    private void SwitchToCharacter2(InputAction.CallbackContext context)
    {
        if (team.Length < 2)
            return;
        currentTeamMember = 1;
        UpdateCurrentCharacter();
    }
    private void SwitchToCharacter3(InputAction.CallbackContext context)
    {
        if (team.Length < 3)
            return;
        currentTeamMember = 2;
        UpdateCurrentCharacter();
    }
    private void SwitchToCharacter4(InputAction.CallbackContext context)
    {
        if (team.Length < 4)
            return;
        currentTeamMember = 3;
        UpdateCurrentCharacter();
    }

    void SetupTeam()
    {
        team = new Character[teamSetup.Length];
        for (int i = 0; i < teamSetup.Length; i++)
        {
            team[i] = new Character(teamSetup[i]);
        }
    }

    void UpdateCurrentCharacter()
    {
        spriteRenderer.sprite = team[currentTeamMember].characterSO.worldSprite;
        playerMovement.SetSpeed(team[currentTeamMember].movementSpeed, team[currentTeamMember].maxSpeed);
        if (switchCharacter != null)
            switchCharacter(team[currentTeamMember]);
    }

    public Character GetCurrentCharacter()
    {
        return team[currentTeamMember];
    }
}
