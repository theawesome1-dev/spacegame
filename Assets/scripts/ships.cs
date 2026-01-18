using UnityEngine;

public class ships : MonoBehaviour
{
     public textSystem textSystem;
    public inventory inventory;
    public string[] text1;
    public string[] text2;
    
    //public Animator _animator;

    InputSystem_Actions input;

    public GameObject brokenShip;
    public GameObject fixedShip;
    
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
                if (inventory.shipParts["ship leg"] == true && inventory.shipParts["thruster"] && inventory.shipParts["ship hull"])
                {
                    textSystem.startText(text2);
                    fixedShip.SetActive(true);
                    inventory.updateUI();
                    brokenShip.SetActive(false);
                }
                else
                {
                    textSystem.startText(text1);
                }
            }
        }
    }
}
