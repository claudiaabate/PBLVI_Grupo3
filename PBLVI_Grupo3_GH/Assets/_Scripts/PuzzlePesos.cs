using UnityEngine;

public class PuzzlePesos : MonoBehaviour
{
    public float pesoTotal = 0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactuable")
        {
            pesoTotal += other.transform.parent.gameObject.GetComponent<ArrastrarObjetos>().peso;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Interactuable")
        {
            pesoTotal -= other.transform.parent.gameObject.GetComponent<ArrastrarObjetos>().peso;
        }
    }
}
