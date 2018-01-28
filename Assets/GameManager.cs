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

    public void resetGame() {
        valvesNumber = 0;
        keysNumber = 0;
        pipesNumber = 0;
    }
}