using System.Collections.Generic;
using UnityEngine;

public static class Config
{
    public static Dictionary<string, bool> GameStates { get; set; }

    public static bool DebugController = false;
    public static bool DebugLight = false;
    public static bool DebugRayTrigger = false;
    public static bool DebugGamestate = false;
    public static bool ShowFps = false;

    public static float triggerTimer = 1.3f;
    public static float travelTime = 5f;

    public static GameObject World { get; set; }

    static Config()
    {
        GameStates = new Dictionary<string, bool>();
        GameStates.Add("gameStarted", true);
        GameStates.Add("crystalGravity", false);
        GameStates.Add("crystalTaken", false);
        GameStates.Add("crystalActivated", false); //mainstate für traveltrigger
        GameStates.Add("firstCubeTaken", false);

        GameStates.Add("vulcanoActivated", false);
        GameStates.Add("torchTaken", false);
        GameStates.Add("iceMelted", false);
        GameStates.Add("secondCubeTaken", false);

        GameStates.Add("shovelTaken", false);
        GameStates.Add("dugUp", false);
        GameStates.Add("thirdCubeTaken", false);


    }
}