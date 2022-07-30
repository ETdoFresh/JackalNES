using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] public GameObject bulletPrefab;
    private InputActions _inputActions;
    private Rigidbody2D _rigidbody2D;
    private Collider2D _collider;

    private void Awake()
    {
        _inputActions = new InputActions();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.ShootBullet.performed += ShootBullet;
    }
    
    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Gameplay.ShootBullet.performed -= ShootBullet;
    }
    
    private void ShootBullet(InputAction.CallbackContext context)
    {
        var bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        //ApplyRelativeForceToBullet(bullet);
        Physics2D.IgnoreCollision(_collider, bullet.GetComponent<Collider2D>());
    }

    private void ApplyRelativeForceToBullet(GameObject bullet)
    {
        var bulletRigidbody2D = bullet.GetComponent<Rigidbody2D>();
        bulletRigidbody2D.velocity = _rigidbody2D.velocity;
    }
}