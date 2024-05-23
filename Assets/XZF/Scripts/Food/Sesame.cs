using System.Collections;
using System.Collections.Generic;
using Tilia.Input.UnityInputManager;
using UnityEngine;

public class Sesame :Food
{
    public static Sesame instance;
    //public Material onionMaterial;
    public GameObject interactable;
    public GameObject tipPanel;
    public GameObject sesameOb;
    public GameObject sesameBtnAct;

    public int flag = 0;

    //private GameObject inputScript;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (isFinishedList[1] == 1 && isFinishedList[0] == 1)
        {
            interactable.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "powl")
        {
            tipPanel.SetActive(true);
            sesameBtnAct.SetActive(true);
            flag = 1;
        }
    }
    public void SesameFinished()
    {
        if(!GameObject.Find("Onion") && !GameObject.Find("Sauce") && flag == 1 )
        {
            Debug.Log("为什么要毁掉芝麻！");
            tipPanel.SetActive(false);
            Destroy(sesameOb);
            isFinishedList[2] = 1;
        }
       
    }
}
