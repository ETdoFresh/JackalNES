using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 _input;
    private InputActions _inputActions;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _inputActions = new InputActions();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.MovementP1.performed += Move;
    }

    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Gameplay.MovementP1.performed -= Move;
    }

    private void Move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = _input * speed;
    }
}
