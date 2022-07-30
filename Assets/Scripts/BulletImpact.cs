using UnityEngine;

public class BulletImpact : MonoBehaviour
{
    [SerializeField] private float lifeTime = 1f;
    
    public void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}