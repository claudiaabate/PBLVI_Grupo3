using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    private string MoveInputAxis = "Vertical";
    private string TurnInputAxis = "Horizontal";

    // Rotacion en angulos por segundo
    public float rotationRate = 360;

    //unidades de movimiento por segundo
    public float moveSpeed = 1f;

    // Update is called once per frame
    private void Update()
    {
        float moveAxis = Input.GetAxis(MoveInputAxis);
        float turnAxis = Input.GetAxis(TurnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}