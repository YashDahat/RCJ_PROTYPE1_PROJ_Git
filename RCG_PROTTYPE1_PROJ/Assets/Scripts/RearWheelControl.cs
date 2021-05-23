using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RearWheelControl : MonoBehaviour
{
    [SerializeField]
    float accelerationConst = 20;

    VehicleControlls controls;
    Rigidbody rb;
    float accelerate;

    private void Awake()
    {
        controls = new VehicleControlls();
        controls.RearWheels.Move.performed += ctx => accelerate = ctx.ReadValue<float>();
        controls.RearWheels.Move.canceled += ctx => accelerate = 0.0f;
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        MoveVehicle();
    }
    private void OnEnable()
    {
        controls.RearWheels.Enable();
    }
    private void OnDisable()
    {
        controls.RearWheels.Disable();
    }
    void MoveVehicle()
    {
        Vector3 axis = new Vector3(0,0,-accelerate*accelerationConst);
        rb.AddTorque(axis);
    }
}
