using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    public static GamePlayController Instance;
    public GameScene gameScene;
    public PlayerContain playerContain;



    public void Awake() //awake chay truoc start, khi script is disabled, awake still runs while start doesnt
    {
        Instance = this;
    }
    void Start()
    {
        gameScene.Init(); //gameScene chay truoc, thats why we need Init
        playerContain.Init();
        
    }
}
