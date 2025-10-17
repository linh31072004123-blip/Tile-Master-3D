using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContain : MonoBehaviour
{
    public InputController inputController;
    public ShopController shopController;
    public void Init()
    {
        inputController.Init();
        shopController.Init();
        
    }
}
