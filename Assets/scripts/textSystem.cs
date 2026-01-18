using UnityEngine;
using TMPro;
using System.Collections;

using UnityEngine.Scripting.APIUpdating;
using Unity.VisualScripting;
using NUnit.Framework;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class textSystem : MonoBehaviour
{

    public string[] lines;
    public TextMeshProUGUI gui;
    public float textSpeed;
    private int index = 0;
    public bool isFinished = false;
    public GameObject pannelText;
    InputSystem_Actions input;
    private bool inputting = false;
    private float time;
    public float finTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                gui.text = string.Empty;
                        inputting = false;
        isFinished = false;
        pannelText.SetActive(true);
        index  = 0;
        gui.text = string.Empty;
    input = new InputSystem_Actions();
    }

    // Update is called once per frame
    void Update()
    {
        
        input.Player.Enable();
        if (index < lines.Length &&  inputting == false)
        {
            if (index == 0)
            {
                startDialog();

            }
            if (index > 0 && input.Player.Interact.WasReleasedThisFrame())
            {
                startDialog();
            }
        }
        if (index == lines.Length && input.Player.Interact.WasReleasedThisFrame())
        {
            pannelText.SetActive(false);
            gui.text = string.Empty;
            time = Time.time + finTime;
        }
        if (Time.time >= time && pannelText.activeSelf == false)
        {
            isFinished = true;
        }
    }
    public void startText(string[] texts)
    {
        lines = texts;
        inputting = false;
        isFinished = false;
        pannelText.SetActive(true);
        index  = 0;
        gui.text = string.Empty;

    }
    void startDialog()
    {
        StartCoroutine(typeLine());
        

    }
     IEnumerator typeLine()
    {
        inputting = true;
        gui.text = string.Empty;

        foreach (char c in lines[index].ToCharArray())
        {
            gui.text += c; 
            yield return new WaitForSeconds(textSpeed);
        }
        inputting = false;
        index++;

    }
}
