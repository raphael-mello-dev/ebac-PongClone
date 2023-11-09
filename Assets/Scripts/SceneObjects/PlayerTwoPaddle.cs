using UnityEngine;

public class PlayerTwoPaddle : MonoBehaviour
{
    #region Paddle atribute

    [SerializeField] private int speed;

    #endregion

    #region Paddle Setup

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = GameInfo.instance.P2Color;
    }

    #endregion

    #region Paddle Update

    void Update()
    {
        if (GameManager.Instance.IsPlaying)
            OnMovement();
    }

    #endregion

    #region Paddle Movement Function

    private void OnMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }

    #endregion
}