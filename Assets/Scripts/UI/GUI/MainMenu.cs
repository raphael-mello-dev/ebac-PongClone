using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    #region Menu Gameobject components

    [Header("UI GameObjects")]
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject boardPanel;
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject boardButton;
    [SerializeField] private GameObject optionsButton;
    [SerializeField] private GameObject exitButton;
    [SerializeField] private GameObject singlePlayerButton;
    [SerializeField] private GameObject twoPlayersButton;
    [SerializeField] private GameObject backButton;

    #endregion

    #region Menu Button components

    [Header("UI Buttons")]
    [SerializeField] private Button play;
    [SerializeField] private Button board;
    [SerializeField] private Button options;
    [SerializeField] private Button exit;
    [SerializeField] private Button singlePlayer;
    [SerializeField] private Button twoPlayers;
    [SerializeField] private Button back;

    #endregion

    #region Main Menu Setup

    private void Start()
    {
        OnMenuEnter();

        play.onClick.AddListener(OnClickPlay);
        board.onClick.AddListener(OnClickMatchBoard);
        options.onClick.AddListener(OnClickOptions);
        exit.onClick.AddListener(OnClickExit);
        singlePlayer.onClick.AddListener(OnClickSinglePlayer);
        twoPlayers.onClick.AddListener(OnClickTwoPlayers);
        back.onClick.AddListener(OnMenuEnter);
    }

    #endregion

    #region Main Menu functions

    protected void BackToMenu()
    {
        optionsPanel.SetActive(false);
        boardPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    protected void OnMenuEnter()
    {
        mainMenuPanel.SetActive(true);
        boardPanel.SetActive(false);
        optionsPanel.SetActive(false);
        playButton.SetActive(true);
        boardButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);
        singlePlayerButton.SetActive(false);
        twoPlayersButton.SetActive(false);
        backButton.SetActive(false);
    }

    private void OnClickPlay()
    {
        playButton.SetActive(false);
        boardButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        singlePlayerButton.SetActive(true);
        twoPlayersButton.SetActive(true);
        backButton.SetActive(true);
    }

    private void OnClickMatchBoard()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        boardPanel.SetActive(true);
    }

    private void OnClickOptions()
    {
        mainMenuPanel.SetActive(false);
        boardPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    private void OnClickSinglePlayer()
    {
        GameInfo.instance.NumPlayers = 1;
        GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.GAMEPLAY);
        GameManager.Instance.HasLoadedGameScene = true;
    }

    private void OnClickTwoPlayers()
    {
        GameInfo.instance.NumPlayers = 2;
        GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.GAMEPLAY);
        GameManager.Instance.HasLoadedGameScene = true;
    }

    private void OnClickExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }

    #endregion
}