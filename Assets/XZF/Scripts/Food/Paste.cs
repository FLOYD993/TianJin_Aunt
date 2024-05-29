using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paste : MonoBehaviour
{
    public static Paste instance;

    public GameObject pasteBowl;
    public GameObject paste;
    public GameObject powl;
    private Vector3 oriPosition;
    public GameObject tipPanel;
    public GameObject pasteBtnAct;

    public int pasteFinished = 0;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        oriPosition = transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("可以判断撞");
        if (collision.gameObject.tag == "powl")
        {
            Debug.Log("放在了锅上");
            tipPanel.SetActive(true);
            pasteBtnAct.SetActive(true);
        }
    }
    public void PasteFinished()
    {
        tipPanel.SetActive(false);
        //生成大饼
        //float tmpY = powl.transform.position.y + 0.08f ;
        //Vector3 tmpPosition = powl.transform.position;
        //tmpPosition.y = tmpY;
        //Instantiate(paste, tmpPosition, Quaternion.identity);
        transform.position = oriPosition;
        paste.SetActive(true);
        //不能对paste生效
        pasteBtnAct.SetActive(false);

        pasteFinished = 1;
    }
}
