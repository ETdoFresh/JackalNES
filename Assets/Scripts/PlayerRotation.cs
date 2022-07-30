using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;
    private Quaternion _targetRotation;
    private InputActions _inputActions;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _inputActions = new InputActions();
        _targetRotation = transform.rotation;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _inputActions.Gameplay.MovementP1.performed += RotateOnMovement;
        _inputActions.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Gameplay.MovementP1.performed -= RotateOnMovement;
        _inputActions.Disable();
    }

    private void Update()
    {
        if (_rigidbody2D.velocity.magnitude > 0.1f)
            transform.rotation = Quaternion.Lerp(transform.rotation, _targetRotation, rotationSpeed * Time.deltaTime);
    }

    private void RotateOnMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction.magnitude < 0.1f) return;
        _targetRotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
}