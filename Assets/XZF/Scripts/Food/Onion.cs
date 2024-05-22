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

    //private GameObject inputScript;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "powl")
        {
            tipPanel.SetActive(true);
            GameObject.Find("Onion").GetComponent<UnityInputManagerButtonAction>().enabled = true;
        }
    }
    public void OnionFinished()
    {
        tipPanel.SetActive(false);
        Destroy(gameObject);
        isFinishedList[0] = 1;
    }
}
