using UnityEngine.SceneManagement;

public class StateGameplay : StateBase
{
    #region Gameplay State functions

    public override void OnEnterState()
    {
        LogManager.Instance.Log("On Gameplay State Enter!");

        GameManager.Instance.IsPlaying = true;

        if (!GameManager.Instance.HasLoadedGameScene)
            SceneManager.LoadScene(1);        
    }

    public override void OnStayState()
    {
        base.OnStayState();
    }

    public override void OnExitState()
    {
        LogManager.Instance.Log("On Gameplay State Exit!");
    }

    #endregion
}