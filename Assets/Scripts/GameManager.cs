using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static void CancelGame()
    {
        UIManager.ResetUI();
        AudioManager.StopBattleMusic();
    }

}
