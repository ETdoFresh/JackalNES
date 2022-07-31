using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Vector2 direction = Vector2.zero;
    [SerializeField] private float force = 100f;
    [SerializeField] private float lifeTime = 2f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(direction * force);
        Destroy(gameObject, lifeTime);
    } 
}