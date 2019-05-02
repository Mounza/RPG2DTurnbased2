using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;
    public GameObject gameMan; //GameManager
    public GameObject audioMan; //audiomanager
    public GameObject battleMan; //Battlemanager

    void Start()
    {
        if (UIFade.instance == null)
        {
           UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
        }
        if(PlayerController.instance == null)
        {
           PlayerController clone = Instantiate(player).GetComponent<PlayerController>();
           PlayerController.instance = clone;
        }

        if(GameManager.instance == null)
        {
            GameManager.instance = Instantiate(gameMan).GetComponent<GameManager>();
        }

        if (AudioManager.instance == null)
        {
            AudioManager.instance = Instantiate(audioMan).GetComponent<AudioManager>();
        }

        if (BattleManager.instance == null)
        {
            BattleManager.instance = Instantiate(battleMan).GetComponent<BattleManager>();
        }
    }
}

