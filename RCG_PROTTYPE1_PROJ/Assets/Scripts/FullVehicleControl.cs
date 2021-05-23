using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FullVehicleControl : MonoBehaviour
{   [SerializeField]
    List<WheelCollider> steering_wheels;
    [SerializeField]
    List<WheelCollider> Motor_wheels;

    VehicleControlls controls;
    Rigidbody rb;

    float move, brake;
    float turn;

    [SerializeField]
    float accelerationcoeff,
        brakingcoeff,
        turnanglecoeff;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controls = new VehicleControlls();
        controls.FullControl.Move.performed += ctx => move = ctx.ReadValue<float>();
        controls.FullControl.Move.canceled += ctx => move = 0;
        controls.FullControl.Turn.performed += ctx => turn = ctx.ReadValue<Vector2>().x;
        controls.FullControl.Turn.canceled += ctx => turn = 0;
        controls.FullControl.Brake.performed += ctx => brake = ctx.ReadValue<float>();
    }

    private void FixedUpdate()
    {
        MoveVehicle();
        BrakeVehicle();
        TurnVehicle();
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    void MoveVehicle()
    {
        foreach(WheelCollider wheel in Motor_wheels)
        {
            wheel.motorTorque = accelerationcoeff * move;
        }
    }
    void BrakeVehicle()
    {
        foreach (WheelCollider wheel in Motor_wheels)
        {
            wheel.brakeTorque = brakingcoeff * brake;
        }
        foreach (WheelCollider wheel in steering_wheels)
        {
            wheel.brakeTorque = brakingcoeff * brake;
        }
    }
    void TurnVehicle()
    {
        foreach (WheelCollider wheel in steering_wheels)
        {
            wheel.steerAngle = turnanglecoeff * turn;
        }
    }
}
