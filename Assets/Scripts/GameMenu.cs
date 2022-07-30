using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    private enum Selection { Players1, Players2, Disabled }

    [SerializeField] private Selection selection;
    [SerializeField] private PlayableDirector director;
    [SerializeField] private GameObject selection1;
    [SerializeField] private GameObject selection2;
    [SerializeField] private AudioSource startSound;
    [SerializeField] private float delayUntilNextScene = 1.5f;
    private InputActions _inputActions;
    private Selection _previousSelection;

    private void Awake()
    {
        _inputActions = new InputActions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }
    
    private void OnDisable()
    {
        RemoveAllListeners();
        _inputActions.Disable();
    }

    private void Update()
    {
        OnSelectionChanged();
    }

    public void StartMenuMode()
    {
        RemoveAllListeners();
        _inputActions.Menu.Start.performed += StartGame;
        _inputActions.Menu.Select.performed += Select;
        selection = Selection.Players1;
    }

    public void StartStoryMode()
    {
        RemoveAllListeners();
        _inputActions.Menu.Start.performed += RestartDirector;
        _inputActions.Menu.Select.performed += RestartDirector;
        selection = Selection.Disabled;
    }

    private void RemoveAllListeners()
    {
        _inputActions.Menu.Start.performed -= StartGame;
        _inputActions.Menu.Select.performed -= Select;
        _inputActions.Menu.Start.performed -= RestartDirector;
        _inputActions.Menu.Select.performed -= RestartDirector;
    }

    private void StartGame(InputAction.CallbackContext context)
    {
        StartCoroutine(StartGameRoutine());
    }

    private void Select(InputAction.CallbackContext context)
    {
        if (selection == Selection.Disabled) return;
        if (selection == Selection.Players1) selection = Selection.Players2;
        else selection = Selection.Players1;
    }

    private void RestartDirector(InputAction.CallbackContext context)
    {
        director.time = 0;
        director.Play();
    }

    private IEnumerator StartGameRoutine()
    {
        _inputActions.Disable();
        director.Pause();
        startSound.Play();
        yield return new WaitForSeconds(delayUntilNextScene);
        SceneManager.LoadScene("Overview");
    }

    private void OnSelectionChanged()
    {
        if (_previousSelection == selection) return;
        _previousSelection = selection;
        switch (selection)
        {
            case Selection.Players1:
                selection1.SetActive(true);
                selection2.SetActive(false);
                break;
            case Selection.Players2:
                selection1.SetActive(false);
                selection2.SetActive(true);
                break;
            case Selection.Disabled:
                selection1.SetActive(false);
                selection2.SetActive(false);
                break;
        }
    }
}
