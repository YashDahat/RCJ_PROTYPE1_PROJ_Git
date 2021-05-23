using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FrontWheelControl : MonoBehaviour
{
    VehicleControlls controls;
    float axis;
    [SerializeField]
    float TotalAngle = 30;

    GameObject FR_Wheel, FL_Wheel;
    private void Awake()
    {
        controls = new VehicleControlls();
        controls.FrontWheels.Turn.performed += ctx => axis = ctx.ReadValue<Vector2>().x;
        controls.FrontWheels.Turn.canceled += ctx => axis = 0.0f;

        //FR_Wheel = transform.GetChild(1).gameObject;
        //FL_Wheel = transform.GetChild(0).gameObject;
    }
    private void OnEnable()
    {
        controls.FrontWheels.Enable();
    }
    private void OnDisable()
    {
        controls.FrontWheels.Disable();
    }
    private void FixedUpdate()
    {
        Rotate();   
    }
    void Rotate()
    {
        float z_rotation = Mathf.Clamp(axis * TotalAngle, -TotalAngle, TotalAngle);
        transform.localEulerAngles = new Vector3(90.0f
            , 0.0f, z_rotation);   
    }
}
