using UnityEngine;

public class treeGive : MonoBehaviour
{
    
    public textSystem textSystem;
    public inventory inventory;
    public string[] text1;
    public string[] text2;
    
    //public Animator _animator;

    InputSystem_Actions input;

    public GameObject game;
    
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
            //Debug.Log("in hat range");
            if (input.Player.Interact.WasReleasedThisFrame() && textSystem.isFinished == true)
            {
                Debug.Log("Start text");
                //if have hat
                if (inventory.items["ladder"] == true)
                {
                    textSystem.startText(text2);
                    inventory.items["ladder"] = false;
                    inventory.shipParts["ship leg"] = true;
                    game.SetActive(false);
                    inventory.updateUI();
                }
                else
                {
                    textSystem.startText(text1);
                }
            }
        }
    }
}
