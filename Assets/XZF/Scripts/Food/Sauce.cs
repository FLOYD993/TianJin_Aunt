using System.Collections;
using System.Collections.Generic;
using Tilia.Input.UnityInputManager;
using UnityEngine;

public class Sauce : Food
{
    public static Sauce instance;
    //public Material onionMaterial;
    public GameObject interactable;
    public GameObject sauceBtnAction;
    public GameObject tipPanel;
    public GameObject sauceOb;
    public GameObject sesameInter;

    public int flag = 0; //判断物体是否已经放在锅子上
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (isFinishedList[0] == 1)
        {
            interactable.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "powl")
        {
            tipPanel.SetActive(true);
            sauceBtnAction.SetActive(true);
            flag = 1;
        }
    }
    public void SauceFinished()
    {
       
        if(!GameObject.Find("Onion") && flag == 1)
        {
            Debug.Log("为什么要毁掉酱！");
            tipPanel.SetActive(false);
            sesameInter.SetActive(true);
            Destroy(sauceOb);
            isFinishedList[1] = 1;
        }
        
    }
}
