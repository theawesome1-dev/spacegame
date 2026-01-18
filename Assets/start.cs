using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
     InputSystem_Actions input;
   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                 input = new InputSystem_Actions();

    }

    // Update is called once per frame
    void Update()
    {
        input.Player.Enable();
        if (input.Player.Interact.WasReleasedThisFrame())
        {
        input.Player.Disable();

        SceneManager.LoadScene("Cylinder");
        }
}
}
