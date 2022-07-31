using UnityEngine;

public class Grenade : MonoBehaviour
{
    [SerializeField] private GameObject grenadeExplosionPrefab;
    [SerializeField] private float force = 100f;
    [SerializeField] private float lifeTime = 2f;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * force);
        Invoke(nameof(Impact), lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Impact();
    }

    private void Impact()
    {
        Instantiate(grenadeExplosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}