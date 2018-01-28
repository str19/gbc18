using UnityEngine;

public class GameManager
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }

            return _instance;
        }
    }

    public int valvesNumber = 0;
    public int keysNumber = 0;
    public int pipesNumber = 0;
    public GameObject fadeInOutObj;
    public bool firstMapFlooded = true;
    public bool secondMapFlooded = true;
    public bool thirdMapFlooded = true;
    public Vector3 lastRoomPosition = Vector3.zero;

    //level 1
    public bool pump1L1Working = false;
    public bool pump2L1Working = false;
    public bool pump3L1Working = false;
    public bool valve1L1got = false;
    public bool valve2L1got = false;
    public bool valve3L1got = false;

    public void resetGame() {
        valvesNumber = 0;
        keysNumber = 0;
        pipesNumber = 0;
        fadeInOutObj = null;
        firstMapFlooded = true;
        secondMapFlooded = true;
        thirdMapFlooded = true;
        lastRoomPosition = Vector3.zero;
        //level 1
        pump1L1Working = false;
        pump2L1Working = false;
        pump3L1Working = false;
        valve1L1got = false;
        valve2L1got = false;
        valve3L1got = false;
}
}