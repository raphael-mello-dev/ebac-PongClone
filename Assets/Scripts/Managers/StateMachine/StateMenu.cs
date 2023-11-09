using UnityEngine.SceneManagement;

public class StateMenu : StateBase
{
    #region Menu State functions

    public override void OnEnterState()
    {
        LogManager.Instance.Log("On Menu State Enter!");
        
        SceneManager.LoadScene(0);
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