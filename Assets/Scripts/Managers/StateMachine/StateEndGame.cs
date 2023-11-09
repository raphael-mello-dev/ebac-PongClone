
public class StateEndGame : StateBase
{
    #region End Game State functions

    public override void OnEnterState()
    {
        LogManager.Instance.Log("On Menu State Enter!");

        GameManager.Instance.StateManager.SwitchState(StateMachine.GameStates.MENU);
    }

    public override void OnStayState()
    {
        base.OnStayState();
    }

    public override void OnExitState()
    {
        LogManager.Instance.Log("On Menu State Exit!");
    }

    #endregion
}