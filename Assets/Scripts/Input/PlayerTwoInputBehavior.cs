using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoInputBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _playerMovement;

    // Start is called before the first frame update
    void Awake()
    {
        _playerMovement = GetComponent<PlayerMovementBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        _playerMovement.MoveDirection = new Vector3(Input.GetAxisRaw("ArrowHorizontal"), 0, Input.GetAxisRaw("ArrowVertical")).normalized;
    }
}
