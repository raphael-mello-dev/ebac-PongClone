using UnityEngine;

public class Ball : MonoBehaviour
{
    #region Ball properties

    [SerializeField] private float dirX;

    public float DirX
    {
        get { return dirX; }
        set { dirX = value; }
    }

    [SerializeField] private float dirY;

    public float DirY
    {
        get { return dirY; }
        set { dirY = value; }
    }

    [SerializeField] private float speed = 2.5f;

    #endregion

    #region Ball Setup

    private void Start()
    {
        ResetBall();
    }

    #endregion

    #region Ball Update

    private void Update()
    {
        if (GameManager.Instance.IsPlaying)
            OnMovement();
    }

    #endregion

    #region Ball Movement functions

    public void SetDirection()
    {
        do
        {
            DirX = (int)Random.Range(-1, 1);
            DirY = Random.Range(-5, 5);
        }
        while (DirX == 0 || DirY == 0);
    }

    private void OnMovement()
    {
        transform.Translate(new Vector2(DirX * speed, DirY) * Time.deltaTime);
    }

    public void IncreaseSpeed()
    {
        speed += 0.5f;
    }

    #endregion

    #region Function for reseting ball position

    public void ResetBall()
    {
        SetDirection();
        speed = 3.5f;
        transform.position = Vector2.zero;
    }

    #endregion
}