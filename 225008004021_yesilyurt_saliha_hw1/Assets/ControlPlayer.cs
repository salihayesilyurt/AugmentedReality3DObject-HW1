using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    FixedJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        if (joystick == null)
            joystick = FindObjectOfType<FixedJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
    }
    void MoveControl()
    {
        float horizontalMovement = joystick.Horizontal; // Keyboard or joystick horizontal input
        float verticalMovement = joystick.Vertical; // Keyboard or joystick vertical input

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement); // Create movement vector
        movement += transform.position;
        transform.LookAt(movement, transform.forward); // Move the object
    }
}
