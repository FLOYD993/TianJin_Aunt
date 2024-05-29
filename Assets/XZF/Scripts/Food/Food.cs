using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    //public int[] isFinishedList = {0, 0, 0, 0 }; //paste, onion、sauce、sesame
    private int onionFinished = 0;
    private int sauceFinished = 0;
    private int sesameFinished = 0;
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
        //isFinishedList[0] = Paste.instance.pasteFinished;
        //isFinishedList[1] = onionFinished;
        //isFinishedList[2] = sauceFinished;
        //isFinishedList[3] = sesameFinished;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("可以判断撞");
        if (collision.gameObject.tag == "paste")
        {
            //Debug.Log("放在了锅上");
            tipPanel.SetActive(true);
            //Debug.Log("现在食物的："+isFinishedList[foodIndex]);
            //Debug.Log("上一个食物的：" + isFinishedList[foodIndex-1]);
            switch(foodIndex)
            {
                case 1:
                    if(Paste.instance.pasteFinished == 1)
                    {
                        foodBtnAct.SetActive(true);
                    };
                    break;
                case 2:
                    if(onionFinished == 1)
                    {
                        foodBtnAct.SetActive(true);
                    };
                    break;
                case 3:
                    if(sauceFinished == 1)
                    {
                        foodBtnAct.SetActive(true);
                    };
                    break;
            }
            //if (isFinishedList[foodIndex-1] == 1)
            //{
            //    foodBtnAct.SetActive(true);
            //}
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
            switch(foodIndex)
            {
                case 1: onionFinished = 1;break;
                case 2: sauceFinished = 1;break;
                case 3: sesameFinished = 1; break;
            }
            pasteMesh.material = pasteNext;
            Destroy(foodOb);

        }
    }
}
