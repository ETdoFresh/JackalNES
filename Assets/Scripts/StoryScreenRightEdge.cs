using UnityEngine;

public class StoryScreenRightEdge : MonoBehaviour
{
    private Camera _camera;
    private Transform _transform;
    private SpriteRenderer _spriteRenderer;
    public int numberOfScreens = 1;

    private void Awake()
    {
        _camera = Camera.main;
        _transform = transform;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        var screenWidth = _camera.orthographicSize * _camera.aspect;
        var spriteWidth = _spriteRenderer.bounds.size.x;
        var position = _transform.position;
        if (numberOfScreens == 1)
            position.x = screenWidth * numberOfScreens + spriteWidth / 2;
        else if (numberOfScreens > 1)
            position.x = screenWidth + 2 * screenWidth * (numberOfScreens - 1) + spriteWidth / 2;
        _transform.position = position;
    }
}