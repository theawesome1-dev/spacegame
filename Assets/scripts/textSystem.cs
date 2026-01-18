using UnityEngine;
using TMPro;
using System.Collections;
public class textSystem : MonoBehaviour
{

    public string[] lines;
    public TextMeshProUGUI gui;
    public float textSpeed;
    private int index;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gui.text = string.Empty;
        startDialog();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void startDialog()
    {
        index = 0;
        StartCoroutine(typeLine());

    }
     IEnumerator typeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            gui.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
