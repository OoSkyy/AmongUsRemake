using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    public Player player;
    public PlayerInputActions playerInputActions;

    void Awake () {
        playerInputActions = new PlayerInputActions ();
    }

    void Update () {
        player.SetMoveInput (playerInputActions.Character.Move.ReadValue <Vector2> ());
    }

    void OnEnable () {
        playerInputActions.Enable ();
    }

    void OnDisable () {
        playerInputActions.Disable ();
    }
}
