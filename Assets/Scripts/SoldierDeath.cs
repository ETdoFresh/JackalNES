using UnityEngine;

public class SoldierDeath : MonoBehaviour
{
    [SerializeField] private float secondsBeforeRemoveBody = 1f;
    
    private void Start()
    {
        Destroy(gameObject, secondsBeforeRemoveBody);
    }
}
