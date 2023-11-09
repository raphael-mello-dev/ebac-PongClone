using UnityEngine;

public class GameMode : MonoBehaviour
{
    #region Paddles

    [SerializeField] private GameObject p2Paddle;
    [SerializeField] private GameObject npcPaddle;

    #endregion

    #region Game Mode Setup

    void Start()
    {
        if (GameInfo.instance.NumPlayers == 1)
        {
            npcPaddle.SetActive(true);
            p2Paddle.SetActive(false);
        }
        else if(GameInfo.instance.NumPlayers == 2)
        {
            npcPaddle.SetActive(false);
            p2Paddle.SetActive(true);
        }
    }

    #endregion
}