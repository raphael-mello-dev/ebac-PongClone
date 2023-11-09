using UnityEngine;

public class StatePaused : StateBase
{
    #region Pause State functions

    public override void OnEnterState()
    {
        LogManager.Instance.Log("On Pause State Enter!");

        GameManager.Instance.IsPaused = !GameManager.Instance.IsPaused;

        if (GameManager.Instance.IsPaused)
            GameManager.Instance.IsPlaying = false;
        else
            GameManager.Instance.IsPlaying = true;
    }

    public override void OnStayState()
    {
        base.OnStayState();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.GAMEPLAY);
        }
    }

    public override void OnExitState()
    {
        LogManager.Instance.Log("On Pause State Exit!");
    }

    #endregion
}