using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private bool wasInit = false;
    public void Init()
    {
        wasInit = true;
    }
    private void Update()
    {
        if(wasInit == true)
        {
            if(Input.GetMouseButtonDown(0))
            {
                var mousePosition = Input.mousePosition;
                var ray = Camera.main.ScreenPointToRay(mousePosition);
                if(Physics.Raycast(ray, out var hit))
                {

                    Debug.Log("Hit: " + hit.collider.gameObject.name);
                    if (hit.collider.gameObject.transform.parent.GetComponent<ObjectinGame>() != null)
                    {
                        GamePlayController.Instance.playerContain.shopController.HandleActionClick(hit.collider.gameObject.transform.parent.GetComponent<ObjectinGame>());

                    }
                    
                }
                    
            }
        }
    }
}
