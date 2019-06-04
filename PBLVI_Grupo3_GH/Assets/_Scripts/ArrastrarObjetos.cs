using UnityEngine;

public class ArrastrarObjetos : MonoBehaviour
{
    public GameObject ui;

    public float speed = 3.5f;
    public float peso = 2f;

    public GameObject parent0;
    public GameObject jugador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(true);
            other.gameObject.GetComponent<RemyControler>().playerInteractuando = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            /*
            float horizontal = Input.GetAxis("Horizontal");

            float vertical = Input.GetAxis("Vertical");

            Vector3 velocity = new Vector3(horizontal, 0, vertical);

            */

            if (Input.GetKeyDown(KeyCode.F))
            {
                other.gameObject.GetComponent<RemyControler>().playerInteractuando = true;
                ui.SetActive(false);

                //velocity = speed * velocity;
                //transform.position += velocity * Time.deltaTime;

                gameObject.transform.parent = jugador.transform;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(false);
            other.gameObject.GetComponent<RemyControler>().playerInteractuando = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F) && gameObject.transform.parent == jugador.transform)
        {
            Debug.Log("no pulsas nada");
            gameObject.transform.parent = parent0.transform;
        }
        
    }
}
