using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Movimiento del personaje")]
    public float speedMovement;
    public Vector3 direccion;
    public CharacterController controller;

    [Header("Movimiento de la cámara")]
    public Vector2 mouseMovement;
    public Camera playerCamera;
    public float rotacionCamaraX;
    public float rotacionPlayerY;

    [Header("Gravedad")]
    public Vector3 movimientoY;
    public float gravity = -9.8f;
    public float jumpHeight;


    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        movimientoY.y += gravity * Time.deltaTime;
        controller.Move(movimientoY * Time.deltaTime);
        if (controller.isGrounded && movimientoY.y < 0)
        {
            movimientoY.y = -2f;
        }
    }

    public void Mover( float vertical, float horizontal)
    {
        direccion.x = horizontal;
        direccion.z = vertical;
      
        direccion = transform.TransformDirection(direccion);

        controller.Move(direccion * Time.deltaTime * speedMovement);
    }

    public void Rotarpersonaje(float rotacionpersonaje) 
    {
        rotacionPlayerY += rotacionpersonaje;
        
        controller.transform.rotation = Quaternion.Euler(0, rotacionPlayerY, 0);

    }

    public void Rotarcamara(float rotacioncamara)
    {
        
        rotacionCamaraX += rotacioncamara;
        rotacionCamaraX = Mathf.Clamp(rotacionCamaraX, -90, 90);
        playerCamera.transform.localRotation = Quaternion.Euler(-rotacionCamaraX,0, 0);

    }

    public void Jump()
    {
        if (controller.isGrounded )
        {
            movimientoY.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}












