using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static StateMachine;

public class GameManager : MonoBehaviour
{
    #region Game Manager Singleton

    public static GameManager Instance { get; private set; }

    #endregion

    #region Game Managers Classes Instances

    public StateMachine StateManager;

    #endregion

    #region Game Manager properties

    [SerializeField] private bool isPlaying;
    public bool IsPlaying
    {
        get { return isPlaying; }
        set { isPlaying = value; }
    }

    [SerializeField] private bool isPaused;

    public bool IsPaused
    {
        get { return isPaused; }
        set { isPaused = value; }
    }

    [SerializeField] private bool hasLoadedGameScene;

    public bool HasLoadedGameScene
    {
        get { return hasLoadedGameScene; }
        set { hasLoadedGameScene = value; }
    }

    #endregion

    #region Game Manager Setup

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
    }

    private void Start()
    {
        StateManager = new StateMachine();
        StateManager.SwitchState(GameStates.GAMESTART);
        HasLoadedGameScene = false;
        IsPlaying = false;
        IsPaused = false;
    }

    #endregion

    #region Game Manager update

    private void Update()
    {
        if (StateManager.CurrentState != null)
            StateManager.CurrentState.OnStayState();
    }

    #endregion
}