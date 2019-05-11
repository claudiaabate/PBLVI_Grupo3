using UnityEngine;

public class ControlCameras : MonoBehaviour
{
    public GameObject camera_general;
    public GameObject camera_orus;

    void Start()
    {
        camera_general.gameObject.SetActive(true);
        camera_orus.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera_general.gameObject.SetActive(false);
            camera_orus.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camera_general.gameObject.SetActive(true);
            camera_orus.gameObject.SetActive(false);
        }
    }
}