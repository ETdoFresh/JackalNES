using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    [SerializeField] private FacingDirection facingDirection;
    
    public FacingDirection FacingDirection => facingDirection;

    private void Update()
    {
        var facingVector = transform.up;
        if (facingVector.magnitude < 0.01f) return;
        var facingAngle = Vector2.SignedAngle(Vector2.up, facingVector);
        while (facingAngle < 0) facingAngle += 360;
        while (facingAngle > 360) facingAngle -= 360;
        if (facingAngle >= 22.5 && facingAngle <= 67.5f) facingDirection = FacingDirection.UpLeft;
        else if (facingAngle >= 67.5 && facingAngle <= 112.5f) facingDirection = FacingDirection.Left;
        else if (facingAngle >= 112.5 && facingAngle <= 157.5f) facingDirection = FacingDirection.DownLeft;
        else if (facingAngle >= 157.5 && facingAngle <= 202.5f) facingDirection = FacingDirection.Down;
        else if (facingAngle >= 202.5 && facingAngle <= 247.5f) facingDirection = FacingDirection.DownRight;
        else if (facingAngle >= 247.5 && facingAngle <= 292.5f) facingDirection = FacingDirection.Right;
        else if (facingAngle >= 292.5 && facingAngle <= 337.5f) facingDirection = FacingDirection.UpRight;
        else facingDirection = FacingDirection.Up;
    }
}