using System.Collections;
using System.Collections.Generic;
using Tilia.Input.UnityInputManager;
using UnityEngine;

public class Sauce : Food
{
    public static Sauce instance;
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
            GameObject.Find("Sauce").GetComponent<UnityInputManagerButtonAction>().enabled = true;
        }
    }
    public void SauceFinished()
    {
        tipPanel.SetActive(false);
        Destroy(gameObject);
        isFinishedList[1] = 1;
    }
}
