using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    protected int[] isFinishedList = {0, 0, 0, 0 }; //paste, onion、sauce、sesame
    public Text[] menuList;
    //public static Onion instance;
    ////public Material onionMaterial;
    ////public GameObject onionInteractable;
    public GameObject tipPanel;
    public GameObject foodOb;
    public GameObject foodBtnAct;

    public int foodIndex;

    public GameObject nextFoodInter;
    private MeshRenderer pasteMesh;
    public GameObject paste;
    public Material pasteNext;



    ////private GameObject inputScript;
    private void Awake()
    {
        //instance = this;
        pasteMesh = paste.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        isFinishedList[0] = Paste.instance.pasteFinished;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("可以判断撞");
        if (collision.gameObject.tag == "paste")
        {
            Debug.Log("放在了锅上");
            tipPanel.SetActive(true);
            if (isFinishedList[foodIndex-1] == 1)
            {
                foodBtnAct.SetActive(true);
            }
        }
    }
    public void FoodFinished()
    {
        if(foodBtnAct.activeSelf)
        {
            tipPanel.SetActive(false);
            if(foodIndex != 3)
            {
                nextFoodInter.SetActive(true);
            }
            pasteMesh.material = pasteNext;
            Destroy(foodOb);
            isFinishedList[foodIndex] = 1;
        }
    }
}
