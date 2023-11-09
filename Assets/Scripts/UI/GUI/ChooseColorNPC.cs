using UnityEngine;
using UnityEngine.UI;

public class ChooseColorNPC : MonoBehaviour
{
    #region Current Button to choose color

    private Button current;

    #endregion

    #region Choose color Setup

    void Start()
    {
        current = GetComponent<Button>();
        current.onClick.AddListener(OnChooseColor);
    }

    #endregion

    #region Choose color function

    private void OnChooseColor()
    {
        GameInfo.instance.NPCColor = current.image.color;
        Debug.Log(GameInfo.instance.NPCColor);
    }

    #endregion
}