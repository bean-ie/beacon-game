using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform cameraCenter;
    [SerializeField] Camera cam;
    [SerializeField] float cameraCenterToAimFraction;
    Vector2 cameraCenterPoint;
    Vector2 currentMousePosInWorld;

    private void Update()
    {
        currentMousePosInWorld = cam.ScreenToWorldPoint(Mouse.current.position.value);
        cameraCenterPoint.x = player.position.x * cameraCenterToAimFraction + currentMousePosInWorld.x * (1 - cameraCenterToAimFraction);
        cameraCenterPoint.y = player.position.y * cameraCenterToAimFraction + currentMousePosInWorld.y * (1 - cameraCenterToAimFraction);
        cameraCenter.position = cameraCenterPoint;
    }

    public Vector2 GetMouseWorldPos()
    {
        return cam.ScreenToWorldPoint(Mouse.current.position.value);
    }
}
