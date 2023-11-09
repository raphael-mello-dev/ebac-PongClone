using System.Collections;
using System.Collections.Generic;

public class StateMachine
{
    #region Game States enum

    public enum GameStates
    {
        GAMESTART,
        MENU,
        GAMEPLAY,
        PAUSED,
        ENDGAME
    }

    #endregion

    #region State Dictionary

    public Dictionary<GameStates, StateBase> StateDictionary;

    #endregion

    #region Current State property

    public StateBase CurrentState {  get; private set; }

    #endregion

    #region State Machine Setup

    public StateMachine()
    {
        LogManager.Instance.Log("State Machine iniciada!");

        StateDictionary = new Dictionary<GameStates, StateBase>();

        StateDictionary.Add(GameStates.GAMESTART, new StateBase());
        StateDictionary.Add(GameStates.MENU, new StateMenu());
        StateDictionary.Add(GameStates.GAMEPLAY, new StateGameplay());
        StateDictionary.Add(GameStates.PAUSED, new StatePaused());
        StateDictionary.Add(GameStates.ENDGAME, new StateEndGame());
    }

    #endregion

    #region Method to switch states

    public void SwitchState(GameStates state)
    {
        if (CurrentState != null)
            CurrentState.OnExitState();

        CurrentState = StateDictionary[state];

        CurrentState.OnEnterState();
    }

    #endregion
}