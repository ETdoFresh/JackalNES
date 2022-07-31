using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject grenadePrefab;
    [SerializeField] private float grenadeCooldown = 1.5f;
    [SerializeField] private float bulletCooldown = 10f;
    private InputActions _inputActions;
    private Collider2D _collider;
    private bool _isShootingBullet;
    private float _grenadeCooldownTimer;
    private float _bulletCooldownTimer;

    private void Awake()
    {
        _inputActions = new InputActions();
        _collider = GetComponent<Collider2D>();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.ShootBullet.performed += ShootBullet;
        _inputActions.Gameplay.ShootBullet.canceled += StopShootBullet;
        _inputActions.Gameplay.ShootGrenade.performed += ShootGrenade;
    }
    
    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Gameplay.ShootBullet.performed -= ShootBullet;
        _inputActions.Gameplay.ShootBullet.canceled -= StopShootBullet;
        _inputActions.Gameplay.ShootGrenade.performed -= ShootGrenade;
    }

    private void Update()
    {
        if (!_isShootingBullet) return;
        if (Time.time < _bulletCooldownTimer) return;
        ShootBullet(default);
    }

    private void ShootBullet(InputAction.CallbackContext context)
    {
        _isShootingBullet = true;
        _bulletCooldownTimer = Time.time + bulletCooldown;
        var bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Physics2D.IgnoreCollision(_collider, bullet.GetComponent<Collider2D>());
    }

    private void StopShootBullet(InputAction.CallbackContext obj)
    {
        _isShootingBullet = false;
    }

    private void ShootGrenade(InputAction.CallbackContext context)
    {
        if (Time.time < _grenadeCooldownTimer) return;
        _grenadeCooldownTimer = Time.time + grenadeCooldown;
        var grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Physics2D.IgnoreCollision(_collider, grenade.GetComponent<Collider2D>());
    }
}