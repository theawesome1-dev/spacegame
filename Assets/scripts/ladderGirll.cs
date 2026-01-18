using UnityEngine;

public class ladderGirll : MonoBehaviour
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
               
                    textSystem.startText(text1);
                    inventory.items["ladder"] = true;
                    game.SetActive(false);
                    inventory.updateUI();
              
            }
        }
    }
}
