using System.Collections;
using UnityEngine;

public class BallColisions : MonoBehaviour
{
    #region Instances in BallColisions

    [SerializeField] private Ball ball;
    [SerializeField] private Score score;

    #endregion

    #region Ball colisions with the game entities

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
            ball.DirY *= -1;
        else if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("NPC"))
        {
            ball.IncreaseSpeed();
            ball.DirX *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("LeftGoal"))
        {
            score.RightScore += 1;
            score.UpdateScore(GameInfo.instance.NumPlayers);
            StartCoroutine(NewGamePoint());
        }
        else if (other.gameObject.CompareTag("RightGoal"))
        {
            score.LeftScore += 1;
            score.UpdateScore(GameInfo.instance.NumPlayers);
            StartCoroutine(NewGamePoint());
        }
    }

    #endregion

    #region Function for reseting ball when someone scores

    private IEnumerator NewGamePoint()
    {
        yield return new WaitForSecondsRealtime(0.75f);
        ball.ResetBall();
    }

    #endregion
}