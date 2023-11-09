using UnityEngine;

public class LogManager : MonoBehaviour
{
    #region Log Manager Singleton

    public static LogManager Instance { get; private set; }

    #endregion

    #region Log Manager property

    [SerializeField] private bool canLog;
    
    public bool CanLog
    {
        get { return canLog; }
        
        set { canLog = value; }
    }

    #endregion

    #region Log Manager Setup

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
    }

    #endregion

    #region Log Manager Methods

    public void Log(string message)
    {
        if (CanLog)
            Debug.Log(message);
    }

    public void Warning(string message)
    {
        if (CanLog)
            Debug.LogWarning(message);
    }

    public void Error(string message)
    {
        if (CanLog)
            Debug.LogError(message);
    }

    #endregion
}