using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class CamMovement : MonoBehaviour
{
    public InputDevice controller;
    private InputActions controls;
    public float vSens;
    public float hSens;
    private Vector2 move;
    public CinemachineFreeLook cam;
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
    private void Awake()
    {
        controls = new InputActions();
        controls.Main.MoveCam.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Main.MoveCam.canceled += ctx => move = Vector2.zero;
    }
    private void FixedUpdate()
    {

        MoveTheCamera();
        
    }

    private void MoveTheCamera()
    {
        cam.m_XAxis.Value += move.x * Time.fixedDeltaTime * hSens;
        cam.m_YAxis.Value -= move.y * Time.fixedDeltaTime * vSens;
    }
}
