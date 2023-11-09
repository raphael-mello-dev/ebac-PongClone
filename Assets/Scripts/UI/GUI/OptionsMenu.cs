using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MainMenu
{
    #region Text Components

    [Header("Options Menu")]
    [SerializeField] private TMP_InputField inputP1;
    [SerializeField] private TMP_InputField inputP2;
    [SerializeField] private TextMeshProUGUI p1Name;
    [SerializeField] private TextMeshProUGUI p2Name;

    #endregion

    #region Buttons

    [SerializeField] private Button save;
    [SerializeField] private Button cleanData;
    [SerializeField] private Button backOptions;

    #endregion

    #region Options Setup

    private void Start()
    {
        p2Name.text = "Player 1";
        p2Name.text = "Player 2";

        save.onClick.AddListener(OnSaveOptions);
        backOptions.onClick.AddListener(OnMenuEnter);
        cleanData.onClick.AddListener(OnCleanData);
    }

    #endregion

    #region Options Input Fields functions

    private void PlayerOneText()
    {
        if (p1Name.text.Length <= 1)
            GameInfo.instance.P1Name = "Player 1";
        else
            GameInfo.instance.P1Name = p1Name.text;
    }

    private void PlayerTwoText()
    {
        if (p2Name.text.Length <= 1)
            GameInfo.instance.P2Name = "Player 2";
        else
            GameInfo.instance.P2Name = p2Name.text;
    }

    #endregion

    #region Options Buttons functions

    private void OnSaveOptions()
    {
        PlayerOneText();
        PlayerTwoText();
        StartCoroutine(OnClickSave());
    }

    private IEnumerator OnClickSave()
    {
        save.GetComponentInChildren<TextMeshProUGUI>().color = Color.yellow;
        yield return new WaitForSecondsRealtime(0.5f);
        save.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
    }

    private void OnCleanData()
    {
        inputP1.text = "";
        inputP2.text = "";

        GameInfo.instance.P1Color = Color.white;
        GameInfo.instance.P2Color = Color.white;
        GameInfo.instance.NPCColor = Color.white;

        StartCoroutine(OnClickCleanData());
    }

    private IEnumerator OnClickCleanData()
    {
        cleanData.GetComponentInChildren<TextMeshProUGUI>().color = Color.yellow;
        yield return new WaitForSecondsRealtime(0.5f);
        cleanData.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
    }

    #endregion
}