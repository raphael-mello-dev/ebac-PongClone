
public class StateBase
{
    #region State Machine basic methods

    public virtual void OnEnterState()
    {
        LogManager.Instance.Log("On State Enter!");
    }

    public virtual void OnStayState()
    {
        LogManager.Instance.Log("On State Stay!");
    }

    public virtual void OnExitState()
    {
        LogManager.Instance.Log("On State Exit!");
    }

    #endregion
}