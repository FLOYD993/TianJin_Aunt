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
            GameObject.Find("Sesame").GetComponent<UnityInputManagerButtonAction>().enabled = true;
        }
    }
    public void SesameFinished()
    {
        tipPanel.SetActive(false);
        Destroy(gameObject);
        isFinishedList[2] = 1;
    }
}
