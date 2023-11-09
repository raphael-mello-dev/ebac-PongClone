using UnityEngine;

public class NPCPaddle : MonoBehaviour
{
    #region NPC Paddle atribute

    [SerializeField] private float speed;

    #endregion

    #region Ball Transform instance

    [SerializeField] private Transform ball;

    #endregion

    #region NPC Paddle Setup

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = GameInfo.instance.NPCColor;
    }

    #endregion

    #region NPC Paddle update

    private void Update()
    {
        if (GameManager.Instance.IsPlaying)
            OnMovement();
    }

    #endregion

    #region Movement function

    private void OnMovement()
    {
        if (gameObject.transform.position.y > ball.position.y)
            gameObject.transform.position -= new Vector3(0, 1, 0) * speed * Time.deltaTime;
        else if (gameObject.transform.position.y < ball.position.y)
            gameObject.transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
    }

    #endregion
}