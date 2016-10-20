using UnityEngine;
using System.Collections;

public class GameStartSettings : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
