using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class Dialogue : MonoBehaviour
{
    private InputAction dialogue;
    [Header("UI")]
    public Text textLabel;
    [Header("文本")]
    public TextAsset textFile;
    public int index;
    public float textspeed;

    bool textfinish;

    List<string> textList=new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        GetTextFromFile(textFile);
        
    }
    private void OnEnable()
    {
        dialogue = new InputAction("Dialogue",binding:"<keyboard>/r");
        dialogue.Enable();
        //textLabel.text = textList[index];
        //index++;
        textfinish = true;
        StartCoroutine(SetTextUI());
    }
    // Update is called once per frame
    void Update()
    {
        if (dialogue.triggered && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if (dialogue.triggered&& textfinish)
        {

            //textLabel.text = textList[index];
            //index++;
            StartCoroutine(SetTextUI());
        }
    }
    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineData=file.text.Split('\n');//文本按行切割 变字符串
        foreach(var line in lineData)
        {
            textList.Add(line);  
        }
    }
    IEnumerator SetTextUI()
    {
        textfinish = false;
        textLabel.text = "";
        for(int i = 0; i < textList[index].Length; i++)
        {
            textLabel.text+= textList[index][i];
            yield return new WaitForSeconds(textspeed);
        }
        textfinish = true;
        index++;
    }
}
