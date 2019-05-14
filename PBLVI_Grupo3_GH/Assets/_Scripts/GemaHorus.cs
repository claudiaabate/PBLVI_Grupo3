using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaHorus : MonoBehaviour
{
    public float PesoCorrecto = 6f;
    private float PesoPuzzle = 0f;

    public GameObject _esconditeHorus;

    private Animator _animator;

    void Start()
    {
        _animator = _esconditeHorus.GetComponent<Animator>();
    }

    private void Update()
    {
        Solución();
    }

    private void Solución()
    {
        PesoPuzzle = gameObject.GetComponentInParent<PuzzlePesos>().pesoTotal;

        if(PesoCorrecto == PesoPuzzle)
        {
            _animator.SetBool("Up", true);
        }
    }
}
