using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using DG.Tweening;

public class ShopController : MonoBehaviour
{
    [SerializeField] List<DataSort> lsDataSort;
    [SerializeField] List<ObjectinGame> lsObjectInGame;
    public DataSort GetData //ham ghep
    {
        get
        {
            foreach (var data in lsDataSort)
            {
                if (data.wasFull == false)
                {
                    return data;
                }
            }
            return null;
        }
    }

    public void Init()
    {
lsObjectInGame = new List<ObjectinGame>();
    }
    public void HandleActionClick(ObjectinGame objectinGameParam)
    {
        var post = GetData;
        if (post != null) // con 1 cho trong
        {
            if (lsObjectInGame.Count <= 0)
            {
                post.wasFull = true;
    objectinGameParam.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    objectinGameParam.transform.GetChild(0).gameObject.GetComponent<MeshCollider>().enabled = false;
    lsObjectInGame.Add(objectinGameParam);
}
                     // post.wasFull = true;
            // objectinGameParam.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            // objectinGameParam.transform.GetChild(0).gameObject.GetComponent<MeshCollider>().enabled = false;
            // objectinGameParam.transform.DOMove(post.postData.transform.position, 0.5f).OnComplete(delegate{

            // })}
            else
            {
                
                int indexInsert = -1;
                int index = -1;
                for (int i = 0; i < lsObjectInGame.Count; i++)
                {
                    if (lsObjectInGame[i].id == objectinGameParam.id)
                    {
                        if (i == lsObjectInGame.Count - 1)
                        {
                            index = 1; //add last
                            
                        }
                        else
                        {
                            index =2; //insert in the middle
                            indexInsert = i;
                            break;
                            

                        }
                    }
                    else
                    {
                        index =1; //no same index
                        

                    }
                }
if(index ==1)
{
    post.wasFull = true;
    objectinGameParam.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    objectinGameParam.transform.GetChild(0).gameObject.GetComponent<MeshCollider>().enabled = false;
    lsObjectInGame.Add(objectinGameParam);
}
else if(index ==2)
{
    post.wasFull = true;
    objectinGameParam.gameObject.GetComponent<Rigidbody>().isKinematic = true;
    objectinGameParam.transform.GetChild(0).gameObject.GetComponent<MeshCollider>().enabled = false;
    lsObjectInGame.Insert(indexInsert + 1, objectinGameParam);
            }
            }
            //doi tuong di chuyen den vi tri postData
            
            HandleMove(); 

        }

    }
    public void HandleMove()
    {
        for (int i = 0; i < lsObjectInGame.Count; i++)
        {
            lsObjectInGame[i].transform.DOMove(lsDataSort[i].postData.transform.position, 0.5f);
        }
    }
}

    [System.Serializable]
public class DataSort
{
    public int id;
    public PostinGamePlay postData;
    public bool wasFull = false;
}
