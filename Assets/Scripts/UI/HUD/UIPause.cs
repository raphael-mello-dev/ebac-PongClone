using UnityEngine;

public class UIPause : MonoBehaviour
{
    #region Pause Update

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.PAUSED);
    }

    #endregion
}