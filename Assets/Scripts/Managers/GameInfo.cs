using System.Collections.Generic;
using UnityEngine;

public class GameInfo
{
    #region Game Info singleton

    public static GameInfo instance = new GameInfo();

    #endregion

    #region Game Info player properties

    private int numPlayers;
    public int NumPlayers
    {
        get { return numPlayers; }
        set { numPlayers = value; }
    }

    private string p1Name;
    public string P1Name
    {
        get { return p1Name; }
        set { p1Name = value; }
    }

    private string p2Name;
    public string P2Name
    {
        get { return p2Name; }
        set { p2Name = value; }
    }

    private string npcName;
    public string NPCName
    {
        get { return npcName; }
        set { npcName = value; }
    }

    private Color p1Color;
    public Color P1Color
    {
        get { return p1Color; }
        set { p1Color = value; }
    }

    private Color p2Color;
    public Color P2Color
    {
        get { return p2Color; }
        set { p2Color = value; }
    }

    private Color npcColor;
    public Color NPCColor
    {
        get { return npcColor; }
        set { npcColor = value; }
    }

    #endregion

    #region Match Board

    public List<string> matchBoard;

    #endregion

    #region Game Info Constructor

    public GameInfo()
    {
        NumPlayers = 0;

        P1Name = "Player 1";
        P2Name = "Player 2";
        NPCName = "NPC";

        P1Color = Color.white;
        P2Color = Color.white;
        NPCColor = Color.white;

        matchBoard = new List<string>();
    }

    #endregion
}