using System;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput, verticalInput;
    private float currentSteerAngle, currentbreakForce;
    private bool isBreaking;

    // Settings
    [SerializeField] private float motorForce, breakForce, maxSteerAngle, downForceCoefficient = 0.75f;
    [SerializeField] private float idleDrag = 2.0f;  // Higher drag when not accelerating
    [SerializeField] private Rigidbody carRigidbody; // Assign this via the inspector

    // Wheel Colliders
    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider, rearRightWheelCollider;

    // Wheels
    [SerializeField] private Transform frontLeftWheelTransform, frontRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform, rearRightWheelTransform;

    // Static variable to control movement
    public static float stopMultiplier = 1.0f;

    private void Start()
    {
        carRigidbody.centerOfMass = new Vector3(0, -0.9f, 0);
    }

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        ApplyDownForce();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        float torque = verticalInput * motorForce * stopMultiplier; // Use stopMultiplier to control torque
        bool isAccelerating = Mathf.Abs(verticalInput) > 0.1 && stopMultiplier > 0; // Check stopMultiplier to determine if accelerating

        frontLeftWheelCollider.motorTorque = isAccelerating ? torque : 0;
        frontRightWheelCollider.motorTorque = isAccelerating ? torque : 0;

        carRigidbody.drag = isAccelerating ? 0.1f : idleDrag;

        currentbreakForce = (isBreaking || stopMultiplier == 0) ? breakForce : 0f; // Use stopMultiplier to control breaking
        ApplyBreaking();
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakForce;
        frontLeftWheelCollider.brakeTorque = currentbreakForce;
        rearLeftWheelCollider.brakeTorque = currentbreakForce;
        rearRightWheelCollider.brakeTorque = currentbreakForce;
    }

    private void HandleSteering()
    {
        if (stopMultiplier > 0) // Only steer if stopMultiplier allows
        {
            currentSteerAngle = maxSteerAngle * horizontalInput;
            frontLeftWheelCollider.steerAngle = currentSteerAngle;
            frontRightWheelCollider.steerAngle = currentSteerAngle;
        }
    }

    private void ApplyDownForce()
    {
        carRigidbody.AddForce(-transform.up * downForceCoefficient * carRigidbody.velocity.sqrMagnitude);
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }
}
    