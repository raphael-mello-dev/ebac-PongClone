using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    #region Paddle atribute

    [SerializeField] private int speed;

    #endregion

    #region Paddle Setup

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = GameInfo.instance.P1Color;
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
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
    }

    #endregion
}