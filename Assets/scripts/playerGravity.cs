using UnityEngine;

public class playerGravity : MonoBehaviour
{
    public GravityAttractor gravityAttractor = null;
    private Rigidbody rb = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = rb.rotation;
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    public void Update()
    {
        
        gravityAttractor.Attract(rb);
    }
}
