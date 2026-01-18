using UnityEngine;

public class hatguyGive : MonoBehaviour
{
    public textSystem textSystem;
    public inventory inventory;
    public string[] text1;
    public string[] text2;
    
    public Animator _animator;

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
            //Debug.Log("in hat range");
            if (input.Player.Interact.WasReleasedThisFrame() && textSystem.isFinished == true)
            {
                Debug.Log("Start text");
                //if have hat
                if (inventory.items["propeller"] == true)
                {
                    textSystem.startText(text2);
                    inventory.items["propeller"] = false;
                    inventory.shipParts["thruster"] = true;
                    _animator.SetBool("HasNewHat", true);
                    inventory.updateUI();
                }
                else
                {
                    print(inventory.items["propeller"]);
                    textSystem.startText(text1);
                }
            }
        }
    }
}
