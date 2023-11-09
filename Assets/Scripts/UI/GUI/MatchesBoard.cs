using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatchesBoard : MainMenu
{
    #region Match Board components

    [SerializeField] private TextMeshProUGUI matchesText;
    [SerializeField] private Button boardBack;

    #endregion

    #region Match Board Setup

    void Start()
    {
        if (GameInfo.instance.matchBoard.Count <= 0)
            matchesText.text = $"\nThere haven't been any recent games.";
        else
        {
            matchesText.text += $"\n";
            for (int i = 0; i <  GameInfo.instance.matchBoard.Count; i++)
                matchesText.text += $"{i+1}º partida: {GameInfo.instance.matchBoard[i]}\n";
        }

        boardBack.onClick.AddListener(OnMenuEnter);
    }

    #endregion
}