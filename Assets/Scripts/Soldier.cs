using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField] private GameObject deathEffect;
    
    private void OnCollisionEnter2D(Collision2D collision2D) =>
        OnCollideOrTrigger(collision2D.gameObject);
    
    private void OnTriggerEnter2D(Collider2D collider2D) =>
        OnCollideOrTrigger(collider2D.gameObject);

    private void OnCollideOrTrigger(GameObject other)
    {
        var bullet = other.GetComponent<Bullet>();
        var explosion = other.GetComponent<Explosion>();
        var playerMovement = other.GetComponent<PlayerMovement>();
        if (!explosion && !playerMovement && !bullet) return;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
