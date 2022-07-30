using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletImpactPrefab;
    [SerializeField] private float force = 100f;
    [SerializeField] private float lifeTime = 2f;
    
    public void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        Invoke(nameof(Impact), lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Impact();
    }

    private void Impact()
    {
        Instantiate(bulletImpactPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}