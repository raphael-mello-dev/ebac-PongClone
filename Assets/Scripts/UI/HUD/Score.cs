using System.Collections;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    #region Score text

    [SerializeField] private TextMeshProUGUI gameScore;

    #endregion

    # region Score properties

    [SerializeField] private int leftScore;

    public int LeftScore
    {
        get { return leftScore; }
        set {  leftScore = value; }
    }

    [SerializeField] private int rightScore;

    public int RightScore
    {
        get { return rightScore; }
        set { rightScore = value; }
    }

    #endregion

    #region End Game objects

    [SerializeField] private GameObject EndGamePanel;
    [SerializeField] private TextMeshProUGUI winningText;

    #endregion

    #region Score Setup

    private void Start()
    {
        LeftScore = 0;
        RightScore = 0;

        EndGamePanel.SetActive(false);
        UpdateScore(GameInfo.instance.NumPlayers);
    }

    #endregion

    #region Function for updating the score

    public void UpdateScore(int players)
    {
        if (players == 1)
            gameScore.text = $"{GameInfo.instance.P1Name}: {LeftScore} x {RightScore} :{GameInfo.instance.NPCName}";
        else if (players == 2)
            gameScore.text = $"{GameInfo.instance.P1Name}: {LeftScore} x {RightScore} :{GameInfo.instance.P2Name}";
        else
            gameScore.text = $"{LeftScore} x {RightScore}";

        WinningCondition(players);
    }

    #endregion

    #region Function to know who is the winner

    private void WinningCondition(int players)
    {
        if (leftScore < 5 && rightScore < 5)
        {
            return;
        }
        else if (leftScore == 5)
        {
            GameManager.Instance.IsPlaying = false;
            GameInfo.instance.matchBoard.Add(gameScore.text);
            StartCoroutine(EndGameScreen());
            winningText.text = $"Congratulations {GameInfo.instance.P1Name}! \n\nYou won!";
        }
        else
        {
            GameManager.Instance.IsPlaying = false;
            GameInfo.instance.matchBoard.Add(gameScore.text);
            StartCoroutine(EndGameScreen());

            if (players == 1)
                winningText.text = $"You lost.";
            else
                winningText.text = $"Congratulations {GameInfo.instance.P2Name}! \n\nYou won!";
        }
    }

    #endregion

    #region End Game functions

    private IEnumerator EndGameScreen()
    {
        yield return new WaitForSecondsRealtime(2f);
        EndGamePanel.SetActive(true);
        StartCoroutine(BackToMenu());
    }

    private IEnumerator BackToMenu()
    {
        yield return new WaitForSecondsRealtime(3.5f);
        GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.ENDGAME);
        GameManager.Instance.HasLoadedGameScene = false;
    }

    #endregion
}