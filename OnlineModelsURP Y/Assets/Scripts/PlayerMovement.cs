using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 6f;
    private InputActions actions;
    public Animator mover;
    public Transform cam;
    public float gravity = -9.81f;


    public float turnTime = 15f;

    public float airControl;
    public float jumpDamp = 0.5f;

    public float groundSpeed = 1f;
    

    public float pushPower = 2.0f;

    Vector3 velocity;
    Vector2 move;
    public float angle;
    bool jump = false;

    public float stepDown = 0.3f;

    public float jumpHeight = 2f;

    [HideInInspector] public Vector3 rootMotion;

    private void Start()
    {
        actions.Main.Enable();
        actions.PauseScreen.Disable();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Awake()
    {
        actions = new InputActions();
        actions.Main.Walk.performed += ctx => move = ctx.ReadValue<Vector2>();
        actions.Main.Walk.canceled += ctx => move = Vector2.zero;

        actions.Main.Jump.performed += ctx => Jump();
    }

    void Jump()
    {
        if (!jump)
        {
            float jumpVel = Mathf.Sqrt(2 * -gravity * jumpHeight);
            SetInAir(jumpVel);
        }
    }

    private void SetInAir(float jumpVel)
    {
        jump = true;
        velocity = mover.velocity * jumpDamp * groundSpeed;
        velocity.y = jumpVel;
        mover.SetBool("Jump", true);
    }

    private void OnEnable()
    {
        actions.Enable();
    }
    private void OnDisable()
    {
        actions.Disable();
    }

    Vector3 CalculateAirControl()
    {
        return ((transform.forward * move.y) + (transform.right * move.x)) * airControl / 100;
    }

    private void FixedUpdate()
    {

        Vector3 direction = new Vector3(move.x, 0, move.y);
        if (direction.magnitude >= 0.1f)
        {
            MoveCharacter(move);
        }
        else
        {
            MoveCharacter(Vector2.zero);
        }

        if (jump)
        {
            UpdateInAir();
        }
        else
        {
            UpdateOnGround();
        }
    }

    private void UpdateOnGround()
    {
        Vector3 stepForwardAmount = move * Time.fixedDeltaTime * groundSpeed;
        Vector3 stepDownAmount = Vector3.down * stepDown;

        controller.Move(stepForwardAmount + stepDownAmount);
        //rootMotion = Vector3.zero;

        if (!controller.isGrounded)
        {
            SetInAir(0);
        }
    }

    private void UpdateInAir()
    {
        velocity.y += gravity * Time.fixedDeltaTime;
        Vector3 displacement = velocity * Time.fixedDeltaTime;
        displacement += CalculateAirControl();
        controller.Move(displacement);
        jump = !controller.isGrounded;
        //rootMotion = Vector3.zero;
        mover.SetBool("Jump", jump);
    }

    void MoveCharacter(Vector2 move)
    {
        Vector3 controllerMove = transform.right * move.x + transform.forward * move.y;
        controller.Move(controllerMove * speed * Time.fixedDeltaTime);

        Vector2 Movement = new Vector2(Mathf.RoundToInt(move.x), Mathf.RoundToInt(move.y));
        Vector2 current = new Vector2(mover.GetFloat("InputX"), mover.GetFloat("InputY"));

        mover.SetFloat("InputX", Mathf.Lerp(current.x, Movement.x, turnTime * Time.fixedDeltaTime));
        mover.SetFloat("InputY", Mathf.Lerp(current.y, Movement.y, turnTime * Time.fixedDeltaTime));
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        // no rigidbody
        if (body == null || body.isKinematic)
            return;

        // We dont want to push objects below us
        if (hit.moveDirection.y < -0.3f)
            return;

        // Calculate push direction from move direction,
        // we only push objects to the sides never up and down
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        // If you know how fast your character is trying to move,
        // then you can also multiply the push velocity by that.

        // Apply the push
        body.velocity = pushDir * pushPower;

    }
}
