using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private AudioSource startSound;
    [SerializeField] private float delayUntilNextScene = 1.5f;
    private InputActions _inputActions;

    private void Awake()
    {
        _inputActions = new InputActions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Menu.Start.performed += StartGame;
    }
    
    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Menu.Start.performed -= StartGame;
    }

    private void StartGame(InputAction.CallbackContext context)
    {
        StartCoroutine(StartGameRoutine());
    }
    
    private IEnumerator StartGameRoutine()
    {
        _inputActions.Disable();
        startSound.Play();
        yield return new WaitForSeconds(delayUntilNextScene);
        SceneManager.LoadScene("Overview");
    }
}
