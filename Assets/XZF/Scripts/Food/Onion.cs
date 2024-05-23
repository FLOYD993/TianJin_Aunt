using System.Collections;
using System.Collections.Generic;
using Tilia.Input.UnityInputManager;
using UnityEditor;
using UnityEngine;

public class Onion : Food
{
    public static Onion instance;
    //public Material onionMaterial;
    //public GameObject onionInteractable;
    public GameObject tipPanel;
    public GameObject onionOb;
    public GameObject onionBtnAct;

    public GameObject sauceInter;
  

    //private GameObject inputScript;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("可以判断撞");
        if(collision.gameObject.tag == "powl")
        {
            Debug.Log("放在了锅上");
            tipPanel.SetActive(true);
            onionBtnAct.SetActive(true);
        }
    }
    public void OnionFinished()
    {
        tipPanel.SetActive(false);
        sauceInter.SetActive(true);
        Destroy(onionOb);
        isFinishedList[0] = 1;
    }
}
