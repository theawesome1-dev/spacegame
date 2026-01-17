using UnityEngine;

public class playerGravity : MonoBehaviour
{
    public GravityAttractor gravityAttractor = null;
    private Rigidbody rb = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void FixedUpdate()
    {
        gravityAttractor.Attract(rb);
    }
}
