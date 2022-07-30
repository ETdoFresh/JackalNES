using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private static readonly int FacingVectorX = Animator.StringToHash("FacingVectorX");
    private static readonly int FacingVectorY = Animator.StringToHash("FacingVectorY");
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        var up = transform.up;
        _animator.SetFloat(FacingVectorX, up.x);
        _animator.SetFloat(FacingVectorY, up.y);
    }
}
