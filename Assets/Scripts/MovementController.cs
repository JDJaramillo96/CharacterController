using UnityEngine;

public class MovementController : MonoBehaviour {

    [SerializeField]
    private float velocity;
    [SerializeField]
    private Rigidbody character;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            character.AddForce(transform.forward * velocity);
        }
    }
}
