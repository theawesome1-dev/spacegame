using UnityEngine;

public class give : MonoBehaviour
{
    public textSystem textSystem;
    public inventory inventory;
    public string[] text;
    InputSystem_Actions input;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         input = new InputSystem_Actions();
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        input.Player.Enable();

        if (other.tag == "Player")
        {
            Debug.Log("plate");
            if (input.Player.Interact.WasReleasedThisFrame() && textSystem.isFinished == true)
            {
                Debug.Log("Start text");
                inventory.items["ladder"] = true;
                inventory.updateUI();
                textSystem.startText(text);
            }
        }
    }
}
