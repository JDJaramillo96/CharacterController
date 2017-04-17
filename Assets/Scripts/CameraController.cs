using UnityEngine;

public class CameraController : MonoBehaviour {

    [SerializeField]
    private float scrollVelocity;

    [Header("Orbit Settings")]

    [SerializeField]
    private float orbitVelocity;
    [SerializeField]
    private Transform target;

    //Cached components
    private new Camera camera;

    private void Awake()
    {
        camera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            ZoomIn();
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            ZoomOut();
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Orbit(Vector3.up);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Orbit(Vector3.down);
        }
    }

    private void ZoomIn()
    {
        camera.transform.position += transform.forward * scrollVelocity;
    }

    private void ZoomOut()
    {
        camera.transform.position -= transform.forward * scrollVelocity;
    }

    private void Orbit(Vector3 axis)
    {
        transform.RotateAround(target.position, axis, orbitVelocity);
    }
}
