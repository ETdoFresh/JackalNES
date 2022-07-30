using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;
    private Quaternion _targetRotation;
    private InputActions _inputActions;

    private void Awake()
    {
        _inputActions = new InputActions();
        _targetRotation = transform.rotation;
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
        transform.rotation = Quaternion.Lerp(transform.rotation, _targetRotation, Time.deltaTime * rotationSpeed);
    }

    private void RotateOnMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        if (direction.magnitude < 0.1f) return;
        _targetRotation = Quaternion.LookRotation(Vector3.forward, direction);
    }
}